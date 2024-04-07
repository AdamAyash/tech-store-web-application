namespace TechStoreWebApplication.Component
{
	#region
	using Microsoft.AspNetCore.Mvc;
	using TechStoreWebApplication.Models;
	using TechStoreWebApplication.Repository.CategoryRepository;
	#endregion


	/// <summary></summary>
	public class CategoryMenu : ViewComponent
	{

        //-------------------------
        //Constants:
        //-------------------------

        //-------------------------
        //Members:
        //-------------------------
        private readonly ICategoryRepository _categoryRepository; 

        //-------------------------
        //Properties:
        //-------------------------

        //-------------------------
        //Constructor/Destructor:
        //-------------------------
        public CategoryMenu(ICategoryRepository categoryRepository)
        {
			_categoryRepository = categoryRepository;
		}

        //-------------------------
        //Methods:
        //-------------------------
        public IViewComponentResult Invoke()
		{
            IEnumerable<Category> categoreis = _categoryRepository.GetCategories()
                .OrderBy(c => c.Name);

			return View(categoreis);
		}
		
		//-------------------------
		//Overrides:
		//-------------------------
	}
}
