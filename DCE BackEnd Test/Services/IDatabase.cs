using DCE_BackEnd_Test.Models;

namespace DCE_BackEnd_Test.Services
{
    internal interface IDatabase
    {
        bool CheckConnection();

        #region Customer Section
        bool InsertCustomer(Customer cus);
        List<Customer> GetCustomers();
        bool UpdateCustomer(Customer cus);
        bool DeleteCustomer(string id);
        List<Order> ActiveOrdersByCustomer(string id);
        #endregion

        /*
        #region Product Section
        Product GetProductById(string id);
        #endregion

        #region Supplier Section
        Supplier GetSupplierById(string id);
        #endregion
        */
    }
}
