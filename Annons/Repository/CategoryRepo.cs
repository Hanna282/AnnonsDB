using Annons.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Annons.Repository
{
    public class CategoryRepo
    {
        private DataContext _context = new();

        public List<Category> GetCategories()
        {
            List<Category> categories = new();

            DataTable result = _context.ExecuteSPReturnTable("GetAllCategories", new List<SqlParameter>());

            foreach (DataRow row in result.Rows)
            {
                Category category = new((int)row.ItemArray[0], row.ItemArray[1].ToString());
                categories.Add(category);
            }
            return categories;
        }
    }
}
