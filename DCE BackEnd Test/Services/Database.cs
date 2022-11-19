using Microsoft.Data.SqlClient;
using DCE_BackEnd_Test.Models;

namespace DCE_BackEnd_Test.Services
{
    internal class Database : IDatabase
    {
        private ICalculation cal = new Calculation();
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
            int IsActive = cal.BoolToIntConvert(cus.IsActive);
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
            Customer cus;
            que = "select * from Customer";
            SqlCommand cmd = new(que, con);
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    while (dr.Read())
                    {
                        cus = new Customer
                        {
                            UserId = dr.GetString(0),
                            Username = dr.GetString(1),
                            Email = dr.GetString(2),
                            FirstName = dr.GetString(3),
                            LastName = dr.GetString(4),
                            CreatedOn = dr.GetDateTime(5),
                            IsActive = cal.IntToBoolConvert(dr.GetInt32(6))
                        };
                        list.Add(cus);
                    }
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            { con.Close(); }
            GC.Collect();
            return list;
        }

        // a method to update a customer data of the database
        bool IDatabase.UpdateCustomer(Customer cus)
        {
            bool response = false;
            que = "update Customer set Username = '"+cus.Username+"', Email = '"+cus.Email+"', FirstName = '"+cus.FirstName+"', LastName = '"+cus.LastName+"', CreatedOn = '"+cus.CreatedOn+"' where UserId = '"+cus.UserId+"'";
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

        // a method to delete a customer from the database
        bool IDatabase.DeleteCustomer(string id)
        {
            bool response = false;
            que = "delete from Customer where UserId = '"+id+"'";
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

        #endregion

        #region Supplier Section
        #endregion

        #region  Product Section
        #endregion
    }
}
