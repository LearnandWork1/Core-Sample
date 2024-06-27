using CoreSample.Model.Service;
using CoreSample.Model.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreSample.Controllers
{
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}


        [HttpGet]                                                            
        [Authorize]
        public IEnumerable<string> Get()
            => new string[] { "John Doe", "Jane Doe" };
       
    }
}
