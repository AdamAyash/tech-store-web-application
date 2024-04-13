namespace TechStoreWebApplication.Controllers.Product
{
	#region
	using Microsoft.AspNetCore.Mvc;
	using TechStoreWebApplication.Models;
	using TechStoreWebApplication.Repository.CategoryRepository;
	using TechStoreWebApplication.Repository.ProductRepository;
	using TechStoreWebApplication.ViewModels;
	#endregion

	/// <summary></summary>
	public class ProductsController : Controller
	{
		//-------------------------
		//Constants:
		//-------------------------

		//-------------------------
		//Members:
		//-------------------------
		private readonly ICategoryRepository _categoryRepository;

		private readonly IProductRepository _productRepository;

		//-------------------------
		//Properties:
		//-------------------------

		//-------------------------
		//Constructor/Destructor:
		//-------------------------
		public ProductsController(ICategoryRepository categoryRepository, IProductRepository productRepository)
		{
			this._categoryRepository = categoryRepository;
			this._productRepository = productRepository;
		}

		//-------------------------
		//Methods:
		//-------------------------
		public IActionResult List(int category)
		{
			Category? recCategory = _categoryRepository.GetCategory(category);

			if(recCategory == null )
			{

			}
			List<Product> oProducts = _productRepository.GetProductsByCategoryID(category).ToList();

			ProductViewModel oProductViewModel = new ProductViewModel();
			oProductViewModel.Products = oProducts;
			oProductViewModel.Category = recCategory;


			return View(oProductViewModel);
		}

		//-------------------------
		//Overrides:
		//-------------------------
	}
}
