using CasaDoCodigo.Data;
using CasaDoCodigo.Data.EfCore;

namespace CasaDoCodigo.Services.DataLoad
{
    public class DataLoadService : IDataLoadService
    {
        private readonly ICategoryDao _categoryDao;
        private readonly ApplicationContext _context;

        public DataLoadService(ApplicationContext context, ICategoryDao categoryDao)
        {
            _context = context;
            _categoryDao = categoryDao;
        }

        public void InitializeDb()
        {
            if (_context.Database.CanConnect()) return;
        }

        private void ImportCategories()
        {
        }
    }
}