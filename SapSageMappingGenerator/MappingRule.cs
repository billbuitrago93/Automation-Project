namespace SapSageMappingGenerator
{
    public class MappingItem
    {
        public string TargetProperty { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }
        public string Comment { get; set; }
    }

    public class MappingRule
    {
        public string FromModel { get; set; }
        public string ToFunction { get; set; }
        public List<MappingItem> Mappings { get; set; }
    }


}
