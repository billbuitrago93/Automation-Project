using System.Text.Json;
using System.Text.RegularExpressions;

namespace SapSageMappingGenerator
{
    public static class SageFunctionHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="defaultCountry"> Choose AU, ZA, or GB. (AU, GB, ZA only)</param>
        /// <returns></returns>
        public static List<SageFunctionItem> GetSageProperties(string filePath, string defaultCountry = "AU")
        {
            var sageProperties = JsonSerializer.Deserialize<List<SageFunctionItem>>(File.ReadAllText(filePath));

            foreach (var item in sageProperties)
            {
                string subPropertyName = null;
                if (IsArrayType(item))
                {
                    subPropertyName = GetArrayPropertyItemType(item);
                }
                else if (IsObjectType(item))
                {
                    subPropertyName = item.Name.Trim();
                }

                if (!string.IsNullOrEmpty(subPropertyName))
                {
                    if (subPropertyName == "VENDORBANKFILEDETAIL")
                    {
                        subPropertyName += "_" + defaultCountry;
                    }
                    item.ObjectProperties = GetSageSubproperties(filePath, subPropertyName, defaultCountry);
                }
            }
            return sageProperties;
        }

        public static string GetPropertyItemTypeFromFilePath(string filePath)
        {
            return Path.GetFileName(filePath).Replace(".json", "");
        }

        public static bool IsArrayType(SageFunctionItem property)
        {
            return (property.Type.StartsWith("array of") || property.Type.EndsWith("]"));
        }

        public static bool IsObjectType(SageFunctionItem property)
        {
            return (property.Type == "object");
        }

        private static List<string> simpleTypes = new List<string>() { "string", "boolean", "currency", "numeric" };
        public static bool IsSimpleType(SageFunctionItem property)
        {
            return (simpleTypes.Contains(property.Type));
        }

        public static string GetArrayPropertyItemType(SageFunctionItem property)
        {
            var propertyName = Regex.Replace(property.Type, @"(array of|\[.*?\])", "");
            return propertyName.Trim();
        }

        private static List<SageFunctionItem> GetSageSubproperties(string parentFilePath, string propertyName, string defaultCountry)
        {
            var path = new FileInfo(parentFilePath).Directory.FullName;
            return GetSageProperties(Path.Combine(path, propertyName.Trim() + ".json"), defaultCountry);
        }
    }
}
