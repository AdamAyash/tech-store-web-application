namespace TechStoreWebApplication.Models
{
	/// <summary></summary>
	public class Product
    {
		public Product()
        {
            ImageUrl = String.Empty;

		}
		public int ID { get; set; }
        public required  int CategoryID {  get; set; }
        public required string ImageUrl { get; set; }
        public double Price { get; set; }
        public bool IsProductOfTheWeek { get; set; }
    }
}
