namespace CasaDoCodigo.Models
{
    public class Register
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public string Complement { get; set; }
        public string District { get; set; }
        public char Fu { get; set; }
        public string ZipCode { get; set; }
        public Order Order { get; set; }
    }
}