using System.Collections.Generic;
using CasaDoCodigo.Models;

namespace CasaDoCodigo.Data.EfCore
{
    public class ProductDao : IProductDao
    {
        private readonly ApplicationContext _context;

        /// <summary>
        ///     Receives an instance of <see cref="ApplicationContext" /> which is responsible for configuring the EF CORE.
        /// </summary>
        public ProductDao(ApplicationContext context)
        {
            _context = context;
        }

        /// <summary>
        ///     Responsible for receiving an enumerable of <see cref="Product" /> to store in the database.
        /// </summary>
        /// <param name="obj">
        ///     Represents an enumerable of <see cref="Product" /> that is passed in the parameter <see cref="obj" />.
        /// </param>
        public void AddRange(IEnumerable<Product> obj)
        {
            _context.AddRange(obj);
            _context.SaveChanges();
        }
    }
}