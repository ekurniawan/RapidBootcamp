﻿
using RapidBootcamp.BackendAPI.Models;
using System.Data.SqlClient;

namespace RapidBootcamp.BackendAPI.DAL
{
    public class OrderDetailsDAL : IOrderDetail
    {
        private string? _connectionString;
        private readonly IConfiguration _config;
        private SqlConnection _connection;
        private SqlCommand _command;
        private SqlDataReader _reader;

        public OrderDetailsDAL(IConfiguration config)
        {
            _config = config;
            _connectionString = _config.GetConnectionString("DefaultConnection");
            _connection = new SqlConnection(_connectionString);
        }

        public IEnumerable<OrderDetail> GetDetailsByHeaderId(string orderHeaderId)
        {
            try
            {
                string query = @"select * from ViewOrderDetail 
                                 where OrderHeaderId=@OrderHeaderId
                                 order by ProductName asc";
                _command = new SqlCommand(query, _connection);
                _command.Parameters.AddWithValue("@OrderHeaderId", orderHeaderId);
                _connection.Open();
                _reader = _command.ExecuteReader();
                List<OrderDetail> orderDetails = new List<OrderDetail>();
                if (_reader.HasRows)
                {
                    while (_reader.Read())
                    {
                        OrderDetail orderDetail = new OrderDetail();
                        orderDetail.OrderDetailId = Convert.ToInt32(_reader["OrderDetailId"]);
                        orderDetail.OrderHeaderId = _reader["OrderHeaderId"].ToString();
                        orderDetail.ProductId = Convert.ToInt32(_reader["ProductId"]);
                        orderDetail.Product = new Product
                        {
                            ProductId = Convert.ToInt32(_reader["ProductId"]),
                            ProductName = _reader["ProductName"].ToString()
                        };
                        orderDetail.Qty = Convert.ToInt32(_reader["Qty"]);
                        orderDetail.Price = Convert.ToDecimal(_reader["Price"]);
                        orderDetails.Add(orderDetail);
                    }
                }
                _reader.Close();
                return orderDetails;
            }
            catch (SqlException sqlEx)
            {
                throw new ArgumentException(sqlEx.Message);
            }
            finally
            {
                _command.Dispose();
                _connection.Close();
            }
        }

        public IEnumerable<OrderDetail> GetAll()
        {
            throw new NotImplementedException();
        }

        public OrderDetail GetById(int id)
        {
            throw new NotImplementedException();
        }

        public OrderDetail Add(OrderDetail entity)
        {
            throw new NotImplementedException();
        }

        public OrderDetail Update(OrderDetail entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
