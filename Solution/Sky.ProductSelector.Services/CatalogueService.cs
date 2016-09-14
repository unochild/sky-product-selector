using System;
using System.Collections.Generic;
using Sky.ProductSelector.Domain;
using Sky.ProductSelector.Interfaces.Data.Repositories;
using Sky.ProductSelector.Interfaces.Services;

namespace Sky.ProductSelector.Services
{
    public class CatalogueService : ICatalogueService
    {
        private readonly ICatalogueRepository _catalogueRepository;

        public CatalogueService(ICatalogueRepository catalogueRepository)
        {
            if (catalogueRepository == null)
            {
                throw new ArgumentNullException("catalogueRepository");
            }
            _catalogueRepository = catalogueRepository;
        }

        public IList<Product> GetProductsByLocationId(string locationId)
        {
            return _catalogueRepository.GetProducts(x => x.LocationId == null || x.LocationId == locationId);
        }
    }
}
