using System;
using System.Collections.Generic;
using System.Linq;
using Sky.ProductSelector.Domain;
using Sky.ProductSelector.Interfaces.Data.Repositories;

namespace Sky.ProductSelector.Data.Repositories
{
    public class InMemoryCatalogueRepository : ICatalogueRepository
    {
        /// <summary>
        /// In memory collection of products
        /// </summary>
        private readonly IList<Product> _products = new List<Product>
        {
            new Product { Category = "Sports", Name = "Arsenal TV", LocationId = "LONDON"},
            new Product { Category = "Sports", Name = "Chelsea TV", LocationId = "LONDON"},
            new Product { Category = "Sports", Name = "Liverpool TV", LocationId = "LIVERPOOL"},
            new Product { Category = "News", Name="Sky News"},
            new Product { Category = "News", Name = "Sky Sports News"}
        };

        public IList<Product> GetProducts(Func<Product, bool> where)
        {
            return _products.Where(where).ToList();
        }
    }
}
