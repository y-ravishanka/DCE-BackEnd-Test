using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DCE_BackEnd_Test.Services;
using DCE_BackEnd_Test.Models;

namespace DCE_BackEnd_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private IDatabase db = new Database();

        [HttpGet]
        [Route("GetAllCustomers")]
        public ActionResult<List<Customer>> GetAllCustomers()
        {
            List<Customer> list;
            try
            {
                list = db.GetCustomers();
                if(list.Count == 0)
                { return (NotFound()); }
                else
                { return (Ok(list)); }
            }
            catch (Exception ex)
            {
                return (BadRequest(ex.Message));
            }
        }

        [HttpGet]
        [Route("GetActiveOrdersByCustomer/{CustomerId}")]
        public ActionResult<List<Order>> GetActiveOrdersByCustomer(string CustomerId)
        {
            List<Order> list;
            try
            {
                list = db.ActiveOrdersByCustomer(CustomerId);
                if (list.Count == 0)
                { return (NotFound()); }
                else
                { return (Ok(list)); }
            }
            catch (Exception ex)
            {
                return (BadRequest(ex.Message));
            }
        }

        [HttpDelete]
        [Route("DeleteCustomer/{CustomerId}")]
        public ActionResult<bool> DeleteCustomer(string CustomerId)
        {
            try
            {
                bool t = db.DeleteCustomer(CustomerId);
                return Ok(t);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("CreateCustomer")]
        public ActionResult<bool> CreateCustomer(Customer cus)
        {
            try
            {
                bool t = db.InsertCustomer(cus);
                return Ok(t);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        [HttpPost]
        [Route("UpdateCustomer")]
        public ActionResult<bool> UpdateCustomer(Customer cus)
        {
            try
            {
                bool t = db.UpdateCustomer(cus);
                return Ok(t);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
