using System.Collections.Generic;

namespace Sky.ProductSelector.Web.Models
{
    /// <summary>
    /// View model for the checkout
    /// </summary>
    public class ProductSelectorCheckoutViewModel
    {
        public ProductSelectorCheckoutViewModel()
        {
            SelectedProducts = new List<string>();
        }

        /// <summary>
        /// Selected products
        /// </summary>
        public IList<string> SelectedProducts { get; set; }

        /// <summary>
        /// The customer id
        /// </summary>
        public int CustomerId { get; set; }
    }
}