namespace CasaDoCodigo.Models
{
    public class Category
    {
        public Category(string name)
        {
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}