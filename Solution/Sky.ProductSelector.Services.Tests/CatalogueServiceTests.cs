using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Moq;
using NUnit.Framework;
using Sky.ProductSelector.Domain;
using Sky.ProductSelector.Interfaces.Data.Repositories;
using Sky.ProductSelector.Interfaces.Services;

namespace Sky.ProductSelector.Services.Tests
{
    [TestFixture]
    public class CatalogueServiceTests
    {
        private Mock<ICatalogueRepository> _catalogueRepositoryMock;
        private ICatalogueService _catalogueService;

        [SetUp]
        public void Setup()
        {
            _catalogueRepositoryMock = new Mock<ICatalogueRepository>();
            _catalogueService = new CatalogueService(_catalogueRepositoryMock.Object);
        }

        [Test]
        public void CanInstantiate()
        {
            // act
            Action action = () => new CatalogueService(_catalogueRepositoryMock.Object);

            // assert
            action.ShouldNotThrow<Exception>(
                "because it should be possible to create an instance of the ICatalogueService");
        }

        [Test]
        public void GetProductsByLocationReturnsListOfProductsForThatLocationAndProductsWithNoLocation()
        {
            // arrange
            const string locationId = "LONDON";

            _catalogueRepositoryMock.Setup(x => x.GetProducts(It.IsAny<Func<Product, bool>>()))
                .Returns(new List<Product>
                {
                    new Product {Category = "Sports", Name = "Arsenal TV", LocationId = "LONDON"},
                    new Product {Category = "Sports", Name = "Chelsea TV", LocationId = "LONDON"},
                    new Product {Category = "News", Name = "Sky News"},
                    new Product {Category = "News", Name = "Sky Sports News"}
                });

            // act
            var products = _catalogueService.GetProductsByLocationId(locationId);

            // assert
            products.Any(x => x.LocationId == locationId)
                .Should()
                .BeTrue("because products should exist with this location");

            products.Any(x => x.LocationId == null).Should().BeTrue("because products should exist with no location");
        }

    }
}
