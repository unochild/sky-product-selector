using System;
using FluentAssertions;
using NUnit.Framework;
using Sky.ProductSelector.Domain;
using Sky.ProductSelector.Interfaces.Services;

namespace Sky.ProductSelector.Services.Tests
{
    [TestFixture]
    public class CustomerLocationServiceTests
    {
        private ICustomerLocationService _customerLocationService;

        [SetUp]
        public void Setup()
        {
            _customerLocationService = new CustomerLocationService();
        }

        [Test]
        public void CanInstantiate()
        {
            // act
            Action action = () => new CustomerLocationService();

            // assert
            action.ShouldNotThrow<Exception>(
                "because we should be able to create a new instance of the customer location service");
        }

        [TestCase(1, "LONDON")]
        [TestCase(2, "LIVERPOOL")]
        public void GetLocationReturnsLocationIdIfLocationExistsForCustomer(int customerId, string expectedLocationId)
        {            
            // act
            var locationId = _customerLocationService.GetLocationId(customerId);

            // assert
            locationId.Should().Be(expectedLocationId, "because that is the expected location id for the customer");
        }

        [Test]
        public void GetLocationThrowsLocationNotFoundExceptionIfNoLocationExistsForCustomer()
        {
            // arrange
            const int customerId = 3;

            // act
            Action action = () => _customerLocationService.GetLocationId(customerId);

            // assert
            action.ShouldThrow<LocationNotFoundException>(
                "because a location is not expected for the provided customer id");
        }
    }
}
