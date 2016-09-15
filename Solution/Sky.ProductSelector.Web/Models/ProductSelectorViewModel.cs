using System.Collections.Generic;
using System.Linq;
using Sky.ProductSelector.Domain;

namespace Sky.ProductSelector.Web.Models
{
    /// <summary>
    /// View model for product selector page
    /// </summary>
    public class ProductSelectorViewModel
    {
        public ProductSelectorViewModel()
        {
            Products = new List<Product>();    
        }

        /// <summary>
        /// The list of products
        /// </summary>
        public IList<Product> Products { get; set; }

        /// <summary>
        /// The distinct list of categories
        /// </summary>
        public IList<string> Categories
        {
            get { return Products.Select(x => x.Category).Distinct().ToList(); }
        }

        /// <summary>
        /// The list of selected products
        /// </summary>
        public IList<string> SelectedProducts { get; set; } 
    }
}