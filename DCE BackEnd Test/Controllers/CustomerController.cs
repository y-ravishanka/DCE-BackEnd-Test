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
    }
}
