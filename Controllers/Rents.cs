using CoreSample.Model;
using CoreSample.Model.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CoreSample.Controllers
{
    //[Route("api/[controller]/[action]")]
    
     //   [Route("api/[controller]/[action]")]
    [Route("api/Rents")]
   // [Route("api/Rents")]

    [ApiController]   
    public class Rents : ControllerBase
    {
        private readonly rentDBContext _context;    

        public Rents(rentDBContext context) 
        {

            _context = context;
        }

        [HttpGet("GetAllRentHomes")]
        public List<RentMaster> GetAllRents()
        {
            try
            {
                var rentsList = _context.rentMasters.ToList();
                return rentsList;
            }
            catch(Exception ex) 
            {
                throw;
            }
        }
    }


    [ApiController]
    public class Depts : ControllerBase
    {
        private readonly rentDBContext _context;

        public Depts(rentDBContext context) { 
        _context = context;}


        [HttpGet("GetAllDepts")]
        public List<DeptMaster> GetAllDepts()
        {
            try
            {
                var deptsList = _context.deptMasters.ToList();
                return deptsList;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
