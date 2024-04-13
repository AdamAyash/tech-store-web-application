namespace TechStoreWebApplication.Controllers.ProductDetails
{
	#region
	using Microsoft.AspNetCore.Mvc;
	using TechStoreWebApplication.Repository.ProductRepository;
	using TechStoreWebApplication.Models;
	#endregion

	/// <summary></summary>
	public class ProductDetailsController : Controller
	{
		//-------------------------
		//Constants:
		//-------------------------

		//-------------------------
		//Members:
		//-------------------------
		private readonly IProductRepository productRepository;

		//-------------------------
		//Properties:
		//-------------------------

		//-------------------------
		//Constructor/Destructor:
		//-------------------------
		public ProductDetailsController(IProductRepository productRepository)
		{
			this.productRepository = productRepository;
		}

		//-------------------------
		//Methods:
		//-------------------------

		//-------------------------
		//Overrides:
		//-------------------------
		public IActionResult Show(int productID)
		{
			Product? product = productRepository.GetProductByID(productID);
			return View(product);
		}
	}
}
