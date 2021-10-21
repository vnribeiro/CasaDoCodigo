namespace CasaDoCodigo.Models
{
    public class Product
    {
        public Product(string code, string name, decimal price)
        {
            Code = code;
            Name = name;
            Price = price;
        }

        public Product(string code, string name, decimal price, Category category)
        {
            Code = code;
            Name = name;
            Price = price;
            Category = category;
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
    }
}