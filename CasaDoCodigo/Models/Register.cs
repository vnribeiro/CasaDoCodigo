namespace CasaDoCodigo.Models
{
    public class Register
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Complement { get; set; }
        public string District { get; set; }
        public char Uf { get; set; }
        public string Cep { get; set; }
        public Order Order { get; set; }
    }
}