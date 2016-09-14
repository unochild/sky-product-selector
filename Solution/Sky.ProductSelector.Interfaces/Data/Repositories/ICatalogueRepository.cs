using System;
using System.Collections.Generic;
using Sky.ProductSelector.Domain;

namespace Sky.ProductSelector.Interfaces.Data.Repositories
{
    /// <summary>
    /// Catalogue data store
    /// </summary>
    public interface ICatalogueRepository
    {
        /// <summary>
        /// Gets a list of products by the supplied where clause
        /// </summary>
        /// <param name="where">The where expression</param>
        /// <returns>A list of products</returns>
        IList<Product> GetProducts(Func<Product, bool> where);
    }
}
