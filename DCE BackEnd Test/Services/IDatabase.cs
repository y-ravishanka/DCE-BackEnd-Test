﻿using DCE_BackEnd_Test.Models;

namespace DCE_BackEnd_Test.Services
{
    internal interface IDatabase
    {
        bool CheckConnection();

        #region  Customer Section
        bool InsertCustomer(Customer cus);
        List<Customer> GetCustomers();
        bool UpdateCustomer(Customer cus);
        bool DeleteCustomer(string id);
        #endregion
    }
}
