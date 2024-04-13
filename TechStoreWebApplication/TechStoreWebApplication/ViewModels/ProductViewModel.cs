namespace TechStoreWebApplication.ViewModels
{
	#region
	using TechStoreWebApplication.Models;
	#endregion

	/// <summary></summary>
	public class ProductViewModel
	{
        //-------------------------
        //Constants:
        //-------------------------

        //-------------------------
        //Members:
        //-------------------------

        //-------------------------
        //Properties:
        //-------------------------
        public IEnumerable<Product> Products { get; set; }
        public Category Category { get; set; }

        //-------------------------
        //Constructor/Destructor:
        //-------------------------

        //-------------------------
        //Methods:
        //-------------------------

        //-------------------------
        //Overrides:
        //-------------------------
    }
}
