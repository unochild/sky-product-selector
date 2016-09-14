namespace Sky.ProductSelector.Domain
{
    /// <summary>
    /// The product dto
    /// </summary>
    public class Product
    {
        /// <summary>
        /// The location id
        /// </summary>
        public string LocationId { get; set; }

        /// <summary>
        /// The product name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The product category
        /// </summary>
        public string Category { get; set; }
    }
}
