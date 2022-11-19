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
                if(list[0].UserId == null || list[0].UserId == "")
                { return (NotFound()); }
                else
                { return (Ok(list)); }
            }
            catch (Exception ex)
            {
                return (BadRequest(ex.Message));
            }
        }
    }
}
