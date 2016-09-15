using System;
using System.Web.Mvc;
using Sky.ProductSelector.Interfaces.Services;
using Sky.ProductSelector.Web.Models;

namespace Sky.ProductSelector.Web.Controllers
{
    /// <summary>
    /// Product selector controller
    /// </summary>
    public class ProductSelectorController : Controller
    {
        private const string CustomerIdSessionKey = "CustomerId";
        private const string SelectedProductsSessionKey = "SelectedProducts";

        /// <summary>
        /// The customer id
        /// Todo - this would be dynamic if the customer had logged in
        /// </summary>
        private int CustomerId
        {
            get
            {
                if (Session[CustomerIdSessionKey] == null)
                {
                    Session[CustomerIdSessionKey] = 1;
                }
                return Convert.ToInt32(Session[CustomerIdSessionKey].ToString());
            }
        }

        private readonly ICatalogueService _catalogueService;
        private readonly ICustomerLocationService _customerLocationService;

        public ProductSelectorController(ICatalogueService catalogueService, ICustomerLocationService customerLocationService)
        {
            if (catalogueService == null)
            {
                throw new ArgumentNullException("catalogueService");
            }
            if (customerLocationService == null)
            {
                throw new ArgumentNullException("customerLocationService");
            }
            _catalogueService = catalogueService;
            _customerLocationService = customerLocationService;
        }

        public ActionResult Index()
        {
            // get location for current customer
            var locationId = _customerLocationService.GetLocationId(CustomerId);

            // get all products for this location
            var products = _catalogueService.GetProductsByLocationId(locationId);

            // create view model and return view
            var viewModel = new ProductSelectorViewModel {Products = products};

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Submit(ProductSelectorViewModel viewModel)
        {
            // add selected items to session and redirect to checkout
            Session[SelectedProductsSessionKey] = string.Join(",", viewModel.SelectedProducts);

            return RedirectToAction("Checkout");
        }

        public ActionResult Checkout()
        {
            // create view model from items in session and return view
            var viewModel = new ProductSelectorCheckoutViewModel {CustomerId = CustomerId};
            if (Session[SelectedProductsSessionKey] != null)
            {
                viewModel.SelectedProducts = Session[SelectedProductsSessionKey].ToString().Split(',');
            }
            return View(viewModel);
        }
    }
}