using System;

namespace TechGadgetCollection
{
    /// <summary>
    /// Base class for collection items
    /// </summary>
    public class CollectionItem
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public DateTime PurchaseDate { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public CollectionItem()
        {
            Name = string.Empty;
            Brand = string.Empty;
            Price = 0;
            Category = string.Empty;
            PurchaseDate = DateTime.Now;
        }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        public CollectionItem(string name, string brand, decimal price, string category, DateTime purchaseDate)
        {
            Name = name;
            Brand = brand;
            Price = price;
            Category = category;
            PurchaseDate = purchaseDate;
        }

        /// <summary>
        /// Returns a summary of the collection item
        /// </summary>
        public virtual string GetSummary()
        {
            return $"{Name} by {Brand} - ${Price:F2} ({Category})";
        }
    }
}
