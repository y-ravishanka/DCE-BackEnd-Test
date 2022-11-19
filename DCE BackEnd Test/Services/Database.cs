using Microsoft.Data.SqlClient;
using DCE_BackEnd_Test.Models;

namespace DCE_BackEnd_Test.Services
{
    internal class Database : IDatabase
    {
        private readonly SqlConnection con = new(@"Data Source=DESKTOP-1G3ODQ5;Initial Catalog=dceBackEndTest;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        private string? que = null;

        #region Check Database Connection Section
        bool IDatabase.CheckConnection()
        {
            bool test = false;
            que = "select 1";
            SqlCommand cmd = new(que, con);
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                    test = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                test = false;
            }
            finally
            { con.Close(); }
            GC.Collect();
            return test;
        }
        #endregion
    
        #region Customer Section
        // a method to insert a customer data to the database
        bool IDatabase.InsertCustomer(Customer cus)
        {
            bool response = false;
            int IsActive = 0;
            que = "insert into(UserId,Username,Email,FirstName,LastName,CreatedOn,IsActive) values( default,'" + cus.Username + "','" + cus.Email + "','" + cus.FirstName + "','" + cus.LastName + "','" + cus.CreatedOn + "'," + IsActive + ")";
            SqlCommand cmd = new(que, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                response = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                response = false;
            }
            finally
            { con.Close(); }
            GC.Collect();
            return response;
        }

        // a method to get data of all customers from the database
        List<Customer> IDatabase.GetCustomers()
        {
            List<Customer> list = new();
            return list;
        }

        // a method to update a customer data of the database
        bool IDatabase.UpdateCustomer(string id)
        {
            bool response = false;
            return response;
        }

        // a method to delete a customer from the database
        bool IDatabase.DeleteCustomer(string id)
        {
            bool response = false;
            return response;
        }

        #endregion

        #region Supplier Section
        #endregion

        #region  Product Section
        #endregion
    }
}
