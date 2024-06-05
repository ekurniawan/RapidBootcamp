using Dapper;
using RapidBootcamp.WebApplication.Models;
using System.Data.SqlClient;

namespace RapidBootcamp.WebApplication.DAL
{
    public class CategoriesDAL : ICategory
    {
        private readonly IConfiguration _configuration;

        public CategoriesDAL(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private string GetConnStr()
        {
            return _configuration.GetConnectionString("DefaultConnection");
        }


        public Category Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAll()
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                string query = @"select * from Categories
                                 order by CategoryName asc";
                var categories = conn.Query<Category>(query);
                return categories;
            }
        }

        public Category GetById(int id)
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                string query = @"select * from Categories
                                 where CategoryId = @CategoryId";
                var param = new { CategoryId = id };
                var category = conn.QuerySingleOrDefault<Category>(query, param);
                if (category == null)
                {
                    throw new ArgumentException("Data not found");
                }
                return category;
            }
        }

        public Category Update(Category entity)
        {
            throw new NotImplementedException();
        }



    }
}
