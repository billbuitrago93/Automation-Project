namespace SapSageMappingGenerator
{
    public class SageFunctionItem
    {
        public string Name { get; set; }
        public string Required { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        /// <summary>
        /// List of properties for this object if it is object type or array of objects
        /// </summary>
        public List<SageFunctionItem>? ObjectProperties { get; set; } = null;
    }
}
