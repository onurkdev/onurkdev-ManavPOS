using onurkdev_ManavPOS.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onurkdev_ManavPOS.Repos
{
    public class ProductRepo : RepositoryBase, IRepository<Product>
    {
        private Product ProductMapping(SqlDataReader reader)
        {
            Product product = new Product(
                Convert.ToInt32(reader["ID"]),
                (reader["ProductName"]).ToString(),
                Convert.ToInt32(reader["CategoryID"]),
                Convert.ToDecimal(reader["Price"]),
                (reader["CategoryName"]).ToString(),
                Convert.ToInt32(reader["SupplierID"]),
                (reader["CompanyName"]).ToString(),
                Convert.ToInt32(reader["ImageID"]),
                Convert.ToInt32(reader["UnitsInStock"]),
                (reader["Unit"]).ToString(),
                Convert.ToInt32(reader["UnitOfMeasureID"]),
                Convert.ToBoolean(reader["IsDeleted"])

                );
            return product;
        }
        public int Create(Product item)
        {
            int returnvalue = 0;

            try
            {
                SqlCommand command = new SqlCommand("Sp_Product_Create_Update", Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("ProductName", item.ProductName);
                command.Parameters.AddWithValue("SupplierID", item.SupplierID);
                command.Parameters.AddWithValue("CategoryID", item.CategoryID);
                command.Parameters.AddWithValue("Price", item.Price);
                command.Parameters.AddWithValue("ImageID", item.ImageID);
                command.Parameters.AddWithValue("UnitOfMeasureID", item.UnitOfMeasureID);
                command.Parameters.AddWithValue("UnitsInStock", item.UnitsInStock);


                if (Connection.State == ConnectionState.Closed) Connection.Open();
                returnvalue = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                if (Connection.State == ConnectionState.Open) Connection.Close();
            }






            return returnvalue;
        }

        public int Delete(int id)
        {
            int returnvalue = 0;

            try
            {
                SqlCommand command = new SqlCommand("Sp_Product_Delete", Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("ID", id);

                if  (Connection.State == ConnectionState.Closed) Connection.Open();
                returnvalue = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                if  (Connection.State == ConnectionState.Open) Connection.Close();
            }
            return returnvalue;
        }

        public List<Product> Get()
        {
            List<Product> products = new List<Product>();
            try
            {
                SqlCommand command = new SqlCommand("Sp_Products", Connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                if (Connection.State == ConnectionState.Closed) Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var product = ProductMapping(reader);
                    products.Add(product);
                }
            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            finally
            {
                if (Connection.State == ConnectionState.Open) Connection.Close();
            }
            return products;
        }

        public Product GetById(int id)
        {
            Product product = null;
            try
            {
                SqlCommand command = new SqlCommand("Sp_Products", Connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", id);
                if (Connection.State == ConnectionState.Closed) Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    product = ProductMapping(reader);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                if (Connection.State == ConnectionState.Open) Connection.Close();
            }
            return product;
        }

        public int Update(Product item)
        {
            int returnvalue = 0;

            try
            {
                SqlCommand command = new SqlCommand("Sp_Product_Create_Update", Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("ID", item.ID);
                command.Parameters.AddWithValue("ProductName", item.ProductName);
                command.Parameters.AddWithValue("SupplierID", item.SupplierID);
                command.Parameters.AddWithValue("CategoryID", item.CategoryID);
                command.Parameters.AddWithValue("Price", item.Price);
                command.Parameters.AddWithValue("ImageID", item.ImageID);
                command.Parameters.AddWithValue("UnitOfMeasureID", item.UnitOfMeasureID);
                command.Parameters.AddWithValue("UnitsInStock", item.UnitsInStock);
                command.Parameters.AddWithValue("IsDeleted", item.IsDeleted);


                if (Connection.State == ConnectionState.Closed) Connection.Open();
                returnvalue = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                if (Connection.State == ConnectionState.Open) Connection.Close();
            }






            return returnvalue;
        }
    }
}
