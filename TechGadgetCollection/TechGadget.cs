using System;

namespace TechGadgetCollection
{
    /// <summary>
    /// Represents a tech gadget in the collection, inheriting from CollectionItem
    /// </summary>
    public class TechGadget : CollectionItem
    {
        /// <summary>
        /// Additional property specific to TechGadget - the warranty period in months
        /// </summary>
        public int WarrantyMonths { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public TechGadget() : base()
        {
            WarrantyMonths = 0;
        }

        /// <summary>
        /// Constructor with parameters - calls base constructor
        /// </summary>
        public TechGadget(string name, string brand, decimal price, string category, DateTime purchaseDate, int warrantyMonths)
            : base(name, brand, price, category, purchaseDate)
        {
            WarrantyMonths = warrantyMonths;
        }

        /// <summary>
        /// Override GetSummary to include warranty information specific to TechGadget
        /// </summary>
        public override string GetSummary()
        {
            string baseSummary = base.GetSummary();
            return $"{baseSummary} - Warranty: {WarrantyMonths} months";
        }
    }
}
