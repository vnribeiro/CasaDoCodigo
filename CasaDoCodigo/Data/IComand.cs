using System.Collections.Generic;

namespace CasaDoCodigo.Data
{
    public interface IComand<in T>
    {
        /// <summary>
        ///     Responsible for receiving an enumerable of <see cref="T" /> to store in the database.
        /// </summary>
        /// <param name="obj">
        ///     Represents an enumerable of <see cref="T" /> that is passed in the parameter <see cref="obj" />.
        /// </param>
        void AddRange(IEnumerable<T> obj);
    }
}