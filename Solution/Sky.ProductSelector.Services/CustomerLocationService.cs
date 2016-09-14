using System;
using Sky.ProductSelector.Domain;
using Sky.ProductSelector.Interfaces.Services;

namespace Sky.ProductSelector.Services
{
    public class CustomerLocationService : ICustomerLocationService
    {
        public string GetLocationId(int customerId)
        {
            string locationId;
            switch (customerId)
            {
                case 1:
                    locationId = "LONDON";
                    break;
                case 2:
                    locationId = "LIVERPOOL";
                    break;
                default:
                    throw new LocationNotFoundException();
            }
            return locationId;
        }
    }
}
