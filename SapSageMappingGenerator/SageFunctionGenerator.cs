using System.Text;
using System.Text.Json;

namespace SapSageMappingGenerator
{
    public static class SageFunctionGenerator
    {
        public static string GetFunctionBody(string mappingRulePapth)
        {
            var mappingRule = JsonSerializer.Deserialize<MappingRule>(File.ReadAllText(mappingRulePapth));

            var mainProperyName = SageFunctionHelper.GetPropertyItemTypeFromFilePath(mappingRule.ToFunction);
            var properties = SageFunctionHelper.GetSageProperties(mappingRule.ToFunction);

            var body = GetFunctionBodyForProperty(mainProperyName, properties, mappingRule);

            return body;
        }

        private static string GetFunctionBodyForProperty(string mainProperyName, List<SageFunctionItem> properties, MappingRule mappingRule, int level = 0, string targetPropertyPath = "")
        {
            var builder = new StringBuilder();

            foreach (var item in properties)
            {
                //           
                if (SageFunctionHelper.IsSimpleType(item))
                {
                    MappingItem fromProperty;
                    if (level == 0)
                    {
                        fromProperty = mappingRule.Mappings.FirstOrDefault(x => x.TargetProperty == item.Name);
                    }
                    else
                    {
                        fromProperty = mappingRule.Mappings.FirstOrDefault(x => x.TargetProperty == $"{targetPropertyPath}.{item.Name}");
                    }

                    if (fromProperty != null)
                    {
                        builder.AppendLine($"// {item.Description}");

                        if (fromProperty?.Type == "Property")
                        {
                            builder.AppendLine($"xml.WriteElement(\"{item.Name}\", model.{fromProperty.Value});");
                        }
                        else if (fromProperty?.Type == "Const")
                        {
                            if (item.Type == "string")
                            {
                                builder.AppendLine($"xml.WriteElement(\"{item.Name}\", \"{fromProperty.Value}\");");
                            }
                            else
                            {
                                builder.AppendLine($"xml.WriteElement(\"{item.Name}\", {fromProperty.Value});");
                            }
                        }
                        else
                        {
                            builder.AppendLine($"xml.WriteElement(\"{item.Name}\", {fromProperty.Value});");
                        }
                        builder.AppendLine("");
                    }
                }
                else if (SageFunctionHelper.IsObjectType(item))
                {
                    var targetProperty = item.Name;
                    if (level > 0)
                    {
                        targetProperty = $"{targetPropertyPath}.{item.Name}";
                    }

                    var subProperties = GetFunctionBodyForProperty(item.Name, item.ObjectProperties, mappingRule, level + 1, targetProperty);
                    builder.AppendLine(subProperties);
                }
                else if (SageFunctionHelper.IsArrayType(item))
                {
                    var itemType = SageFunctionHelper.GetArrayPropertyItemType(item);
                    var targetProperty = $"{item.Name}.{itemType}";
                    if (level > 0)
                    {
                        targetProperty = $"{targetPropertyPath}.{item.Name}";
                    }
                    var subProperties = GetFunctionBodyForProperty(itemType, item.ObjectProperties, mappingRule, level + 1, targetProperty);

                    var sourceListNameMatch = mappingRule.Mappings.FirstOrDefault(x => x.Value.Split(".").Count() == (3 + level));
                    var sourceListName = $"model.{item.Name}";
                    var sourceListItemName = $"item";
                    if (sourceListNameMatch != null)
                    {
                        var names = sourceListNameMatch.Value.Split(".");
                        sourceListName = $"model.{names[0]}";
                        sourceListItemName = names[1];

                        subProperties = subProperties.Replace(sourceListName + ".", "");
                    }

                    if (subProperties.Length > 0)
                    {
                        // Start
                        builder.AppendLine("");
                        builder.AppendLine($"xml.WriteStartElement(\"{item.Name}\");");

                        builder.AppendLine("");
                        builder.AppendLine($"foreach (var {sourceListItemName} in {sourceListName})");
                        builder.AppendLine("{");
                        builder.AppendLine(subProperties);
                        builder.AppendLine("}");

                        // End
                        builder.AppendLine($"// End of {item.Name}");
                        builder.AppendLine($"xml.WriteEndElement();");
                        builder.AppendLine("");

                    }
                }
            }

            if (builder.ToString().Length > 0)
            {
                var builderReturn = new StringBuilder();

                // Start
                builderReturn.AppendLine("");
                builderReturn.AppendLine($"xml.WriteStartElement(\"{mainProperyName}\");");
                builderReturn.AppendLine("");

                builderReturn.Append(builder.ToString());

                // End
                builderReturn.AppendLine($"// End of {mainProperyName}");
                builderReturn.AppendLine($"xml.WriteEndElement();");

                return builderReturn.ToString();
            }

            return "";
        }
    }
}
