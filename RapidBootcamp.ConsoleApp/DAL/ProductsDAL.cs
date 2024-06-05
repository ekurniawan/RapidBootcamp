using RapidBootcamp.ConsoleApp.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapidBootcamp.ConsoleApp.DAL
{
    public class ProductsDAL : IProduct
    {
        private string? _connectionString;
        private SqlConnection _connection;
        private SqlCommand _command;
        private SqlDataReader _reader;

        public ProductsDAL()
        {
            _connectionString = @"Server=.\;Database=RapidDb;Trusted_Connection=True;";
            _connection = new SqlConnection(_connectionString);
        }

        public Product Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            try
            {
                List<Product> products = new List<Product>();
                string query = @"SELECT * FROM Products order by ProductName asc";
                _command = new SqlCommand(query, _connection);
                _connection.Open();
                _reader = _command.ExecuteReader();
                if (_reader.HasRows)
                {
                    while (_reader.Read())
                    {
                        products.Add(new Product
                        {
                            ProductId = Convert.ToInt32(_reader["ProductId"]),
                            ProductName = _reader["ProductName"].ToString(),
                            CategoryId = Convert.ToInt32(_reader["CategoryId"]),
                            Price = Convert.ToDecimal(_reader["Price"]),
                            Stock = Convert.ToInt32(_reader["Stock"])
                        });
                    }
                }
                _reader.Close();
                return products;
            }
            catch (SqlException sqlEx)
            {
                throw new ArgumentException(sqlEx.Message);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                _command.Dispose();
                _connection.Close();
            }
        }

        public IEnumerable<Product> GetByCategory(int categoryId)
        {
            try
            {
                string query = @"select * from Products where CategoryId=@CategoryId";
                _command = new SqlCommand(query, _connection);
                _command.Parameters.AddWithValue("@CategoryId", categoryId);
                _connection.Open();
                _reader = _command.ExecuteReader();
                List<Product> products = new List<Product>();
                if (_reader.HasRows)
                {
                    while (_reader.Read())
                    {
                        products.Add(new Product
                        {
                            ProductId = Convert.ToInt32(_reader["ProductId"]),
                            ProductName = _reader["ProductName"].ToString(),
                            CategoryId = Convert.ToInt32(_reader["CategoryId"]),
                            Price = Convert.ToDecimal(_reader["Price"]),
                            Stock = Convert.ToInt32(_reader["Stock"])
                        });
                    }
                }
                _reader.Close();
                return products;
            }
            catch (SqlException sqlEx)
            {
                throw new ArgumentException(sqlEx.Message);
            }
            finally
            {
                _connection.Close();
                _command.Dispose();
            }
        }

        public Product GetById(int id)
        {
            try
            {
                Product product = new Product();
                string query = @"select * from Products where ProductId=@ProductId";
                _command = new SqlCommand(query, _connection);
                _command.Parameters.AddWithValue("@ProductId", id);
                _connection.Open();
                _reader = _command.ExecuteReader();
                if (_reader.HasRows)
                {
                    _reader.Read();
                    product.ProductId = Convert.ToInt32(_reader["ProductId"]);
                    product.ProductName = _reader["ProductName"].ToString();
                    product.CategoryId = Convert.ToInt32(_reader["CategoryId"]);
                    product.Price = Convert.ToDecimal(_reader["Price"]);
                    product.Stock = Convert.ToInt32(_reader["Stock"]);
                }
                else
                {
                    throw new ArgumentException($"ProductId {id} not found");
                }
                _reader.Close();
                return product;
            }
            catch (SqlException sqlEx)
            {
                throw new ArgumentException(sqlEx.Message);
            }
            finally
            {
                _connection.Close();
                _command.Dispose();
            }
        }

        public IEnumerable<Product> GetByProductName(string productName)
        {
            throw new NotImplementedException();
        }

        public Product Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
