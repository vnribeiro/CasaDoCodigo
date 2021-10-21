using System.Collections.Generic;

namespace CasaDoCodigo.Data
{
    public interface IQuery<out T>
    {
        IEnumerable<T> GetAll();
    }
}