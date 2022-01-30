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
    internal class CustomerRepo : RepositoryBase, IRepository<Customer>
    {
        private Customer CustomerMapping(SqlDataReader reader)
        {
            Customer customer = new Customer(
                Convert.ToInt32(reader["ID"]),
                (reader["FirstName"]).ToString(),
                (reader["LastName"]).ToString(),
                Convert.ToInt32(reader["NationalID"])
                );
            return customer;
        }
        public int Create(Customer item)
        {
            int returnvalue = 0;

            try
            {
                SqlCommand command = new SqlCommand("Sp_Customer_Create_Update", Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("FirstName", item.FirstName);
                command.Parameters.AddWithValue("LastName", item.LastName);
                command.Parameters.AddWithValue("NationalID", item.NationalID);
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
                SqlCommand command = new SqlCommand("Sp_Customer_Delete", Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("ID", id);

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

        public List<Customer> Get()
        {
            List<Customer> customers = new List<Customer>();
            try
            {
                SqlCommand command = new SqlCommand("Sp_Customer_Get", Connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                if (Connection.State == ConnectionState.Closed) Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Customer customer = CustomerMapping(reader);
                    customers.Add(customer);
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
            return customers;
        }

        public Customer GetById(int id)
        {
            Customer customer = null;
            try
            {
                SqlCommand command = new SqlCommand("Sp_Customer_GetByID", Connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", id);
                if (Connection.State == ConnectionState.Closed) Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    customer = CustomerMapping(reader);
                    
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
            return customer;
        }

        public int Update(Customer item)
        {
            int returnvalue = 0;

            try
            {
                SqlCommand command = new SqlCommand("Sp_Customer_Create_Update", Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("ID", item.FirstName);
                command.Parameters.AddWithValue("FirstName", item.FirstName);
                command.Parameters.AddWithValue("LastName", item.LastName);
                command.Parameters.AddWithValue("NationalID", item.NationalID);
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
