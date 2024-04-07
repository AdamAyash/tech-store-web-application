namespace TechStoreWebApplication.Models
{
	/// <summary></summary>
	public class Product
    {
        public int ID { get; set; }
        public required Category Category {  get; set; }
        public required string ImageUrl { get; set; }
        public double Price { get; set; }
        public bool IsProductOfTheWeek { get; set; }
    }
}
