using System.Collections.Generic;
using System.Linq;
using CasaDoCodigo.Models;

namespace CasaDoCodigo.Data.EfCore
{
    public class CategoryDao : ICategoryDao
    {
        private readonly ApplicationContext _context;

        /// <summary>
        ///     Receives an instance of <see cref="ApplicationContext" /> which is responsible for configuring the EF CORE.
        /// </summary>
        public CategoryDao(ApplicationContext context)
        {
            _context = context;
        }

        /// <summary>
        ///     Responsible for receiving an enumerable of <see cref="Category" /> to store in the database.
        /// </summary>
        /// <param name="obj">
        ///     Represents an enumerable of <see cref="Category" /> that is passed in the parameter <see cref="obj" />.
        /// </param>
        public void AddRange(IEnumerable<Category> obj)
        {
            _context.AddRange(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Category> GetAll()
        {
            return _context.Categories.ToList();
        }
    }
}