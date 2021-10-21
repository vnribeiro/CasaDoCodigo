using System.Collections.Generic;
using System.IO;
using System.Linq;
using CasaDoCodigo.Data;
using CasaDoCodigo.Data.EfCore;
using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace CasaDoCodigo.Services.DataLoad
{
    public class DataLoadService : IDataLoadService
    {
        private readonly ICategoryDao _categoryDao;
        private readonly ApplicationContext _context;
        private readonly IProductDao _productDao;

        public DataLoadService(ApplicationContext context, ICategoryDao categoryDao, IProductDao productDao)
        {
            _context = context;
            _categoryDao = categoryDao;
            _productDao = productDao;
        }

        /// <summary>
        ///     Check if the database is created, if it has not and generated a migration and import of category and product data.
        /// </summary>
        public void InitializeDb()
        {
            if (_context.Database.CanConnect()) return;

            _context.Database.Migrate();
            ImportCategories();
            ImportProducts();
        }

        /// <summary>
        ///     Import the categories into the database.
        /// </summary>
        private void ImportCategories()
        {
            var books = LoadFileAndCreateObject();
            var categoriesGroup = books.Select(x => x.Category.ToLower()).Distinct();
            var categories = categoriesGroup.Select(category => new Category(category));
            _categoryDao.AddRange(categories);
        }

        /// <summary>
        ///     Imports the products into the database and associates the product with an existing category.
        /// </summary>
        private void ImportProducts()
        {
            var books = LoadFileAndCreateObject();
            var categories = _categoryDao.GetAll();
            var products = books
                .Select(book => new Product(book.Code, book.Name, book.Price,
                    categories.First(x => x.Name.Equals(book.Category.ToLower()))));

            _productDao.AddRange(products);
        }

        /// <summary>
        ///     Reads the books.json file and returns an enumerable book object.
        /// </summary>
        private IEnumerable<Books> LoadFileAndCreateObject()
        {
            var json = File.ReadAllText(@"Files\livros.json");
            return JsonConvert.DeserializeObject<IEnumerable<Books>>(json);
        }

        /// <summary>
        ///     Struct for create object book.
        /// </summary>
        private struct Books
        {
            [JsonProperty("Codigo")]
            public string Code { get; set; }

            [JsonProperty("Nome")]
            public string Name { get; set; }

            [JsonProperty("Categoria")]
            public string Category { get; set; }

            [JsonProperty("Preco")]
            public decimal Price { get; set; }
        }
    }
}