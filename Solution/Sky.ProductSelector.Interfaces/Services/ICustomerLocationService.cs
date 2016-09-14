namespace Sky.ProductSelector.Interfaces.Services
{
    /// <summary>
    /// The customer location service
    /// </summary>
    public interface ICustomerLocationService
    {
        /// <summary>
        /// Gets the customer location id from the customer id
        /// </summary>
        /// <param name="customerId">The customer id</param>
        /// <returns>A customer location id</returns>
        string GetLocationId(int customerId);
    }
}
