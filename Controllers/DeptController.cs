using CoreSample.Model.Interface;
using CoreSample.Model.ViewModel;
using CoreSample.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

namespace CoreSample.Controllers
{
    [Route("api/Depts/")]
    [EnableCors("AllowOrigin")]
    public class DeptController : ControllerBase
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}


        [NonAction]
        public ObjectResult SetError(Exception e)
        {
            return StatusCode(500, e.Message);
        }



        private readonly IDept _idepttService;
        private readonly rentDBContext _context;

        public DeptController(IDept idepttService)
        {
            _idepttService = idepttService;
        }


        [HttpGet("GetAllDepts")]
        public async Task<List<DeptMaster>> GetAllDepts()
        {

            try
            {
                var List = await _idepttService.GetAllDepts();
                return List;

            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost("AddDepts")]
        public async Task<int> AddDepts([FromBody] DeptMaster deptmaster)
        {
            try
            {
                int Result = await _idepttService.AddDept(deptmaster);
                return Result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
