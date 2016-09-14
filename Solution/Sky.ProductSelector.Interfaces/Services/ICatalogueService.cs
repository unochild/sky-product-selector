using System.Collections.Generic;
using Sky.ProductSelector.Domain;

namespace Sky.ProductSelector.Interfaces.Services
{
    /// <summary>
    /// Catalogue service
    /// </summary>
    public interface ICatalogueService
    {
        /// <summary>
        /// Gets a list of products by location id
        /// </summary>
        /// <param name="locationId">The location id</param>
        /// <returns>A list of products</returns>
        IList<Product> GetProductsByLocationId(string locationId);
    }
}
