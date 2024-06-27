using CoreSample.Model;
using CoreSample.Model.Interface;
using CoreSample.Model.Service;
using CoreSample.Model.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using static CoreSample.Controllers.RentHomeController;

namespace CoreSample.Controllers
{
    //[Produces("application/json")]
    [Route("api/RentHomes/")]
    public class RentHomeController : ControllerBase
    {
        [NonAction]
        public ObjectResult SetError(Exception e)
        {
            return StatusCode(500, e.Message);
        }

        private readonly IRent _irentService;
        // private readonly rentDBContext _context;

        public RentHomeController(IRent irentService)
        {
            _irentService = irentService;
        }


        //[HttpGet("GetAllPatientDetails2")]
        //public async Task<List<PatientDetailsMaster>> GetAllPatientDetails2(string name)
        //{
        //    try
        //    {
        //        var List = await _irentService.GetAllPatientDetails2();
        //        // var cultureobj2 = name.Trim();

        //        return List;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}

        [HttpGet("GetAllRents1")]
        public async Task<List<RentMaster>> GetAllRents1(string name)
        {
            try
            {
                var List = await _irentService.GetAllRenthomes();
                //var cultureobj2 = name.Trim();

                return List;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public class ApiResponse
        {
            public int StatusCode { get; set; }
            public string Message { get; set; }
            // public T Data { get; set; }
        }

        [HttpPut("UpdateRentHome")]
        //[HttpPut][Route("UpdateRentHome2")]
        public ApiResponse UpdateRentHome(RentMaster rentMaster)
        {
            ApiResponse result = new RentHomeController.ApiResponse();
            try
            {
                int res = _irentService.UpdateRentHome(rentMaster);
                result.StatusCode = 500;
                result.Message = "Success";
                // var cultureobj2 = name.Trim();

                return result;
            }
            catch (Exception ex)
            {
                result.StatusCode = 500;
                result.Message = "failed";
                throw;
            }
        }



        [HttpDelete("DeleteRentByID")]
        public bool DeleteRentByID(int ID)
        {
            try
            {
                var res = _irentService.DeleteRentHome(ID);
                // var cultureobj2 = name.Trim();

                return res;
            }
            catch (Exception ex)
            {
                throw;
            }
        }



        //[HttpGet("GetAllRents1")]
        //public async Task<List<RentMaster>> GetAllRents1()
        //{
        //    try
        //    {
        //        var List = await _irentService.GetAllRenthomes();
        //        return List;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}

        [HttpPost("AddRentHome2")]
        public async Task<int> AddRentHomes2([FromBody] RentMaster rentmaster)
        {
            try
            {
                int Result = await _irentService.AddRentHomes(rentmaster);
                return Result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
