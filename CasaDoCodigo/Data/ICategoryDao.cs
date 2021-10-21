using CasaDoCodigo.Models;

namespace CasaDoCodigo.Data
{
    public interface ICategoryDao : IQuery<Category>, IComand<Category>
    {
    }
}