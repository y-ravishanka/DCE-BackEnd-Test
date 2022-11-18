using Microsoft.Data.SqlClient;

namespace DCE_BackEnd_Test.Services
{
    internal class Database : IDatabase
    {
        private readonly SqlConnection con = new(@"Data Source=DESKTOP-1G3ODQ5;Initial Catalog=dceBackEndTest;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        private string? que = null;

        #region Check Database Connection
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
    }
}
