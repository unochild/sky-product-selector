using FluentAssertions;
using NUnit.Framework;
using Sky.ProductSelector.Data.Repositories;
using Sky.ProductSelector.Interfaces.Data.Repositories;

namespace Sky.ProductSelector.Data.Tests.Repositories
{
    [TestFixture]
    public class InMemoryCatalogueRepositoryTests
    {
        private ICatalogueRepository _catalogueRepository;

        [SetUp]
        public void Setup()
        {
            _catalogueRepository = new InMemoryCatalogueRepository();    
        }

        [TestCase("Sports", "LONDON")]
        [TestCase("Sports", "LIVERPOOL")]
        [TestCase("News", null)]
        public void GetProductsByCategoryAndLocationIdShouldReturnListOfProducts(string category, string locationId)
        {
            // act
            var products = _catalogueRepository.GetProducts(x => x.Category == category && x.LocationId == locationId);

            // assert
            products.Should().NotBeEmpty("because products should be returned with this category and location id");
        }
    }
}
