using CoreSample.Model.Interface;
using CoreSample.Model.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreSample.Controllers
{
    //[Produces("application/json")]
    [Route("api/PatientDetails/")]
    public class PatientDetailsController : ControllerBase
    {
        //private ILoggerManager _logger;
        //public PatientDetailsController(ILoggerManager logger)
        //{
        //    _logger = logger;
        //}

        [NonAction]
        public ObjectResult SetError(Exception e)
        {
            return StatusCode(500, e.Message);
        }

        private readonly IPatientDetails _iPatientDetailsService;
        // private readonly rentDBContext _context;

        public PatientDetailsController(IPatientDetails iPatientDetailsService)
        {
            _iPatientDetailsService = iPatientDetailsService;
        }



        [HttpGet("GetAllPatientDetails")]
        public async Task<List<PatientDetailsMaster>> GetAllPatientDetails(string name)
        {

        


            var List = await _iPatientDetailsService.GetAllPatientDetails();
               // var cultureobj2 = name.Trim();

                return List;
            
        }

        //[HttpGet("internal-error")]
        //public ActionResult GetInternalError()
        //{
        //    // Simulate an internal server error
        //    throw new InternalServerErrorException("An unexpected error occurred.");
        //}
        [HttpPost("AddPatientDetails")]
        public async Task<int> AddPatientDetails([FromBody] PatientDetailsMaster patientDetailsmaster)
        {
            try
            {
                int Result = await _iPatientDetailsService.AddPatientDetails(patientDetailsmaster);
                return Result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public class ApiResponseLogs
        {
            public int StatusCode { get; set; }
            public string Message { get; set; }
            // public T Data { get; set; }
        }

        [HttpPut("UpdatePatientDetails")]
        //[HttpPut][Route("UpdatePatientDetails2")]
        public ApiResponseLogs UpdatePatientDetails(PatientDetailsMaster patientDetailsMaster)
        {
            ApiResponseLogs result = new PatientDetailsController.ApiResponseLogs();
            try
            {
                PatientDetailsMaster patientDetailsMasterList = _iPatientDetailsService.UpdatePatientDetailsByID(patientDetailsMaster);
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
                var res = _iPatientDetailsService.DeletePatientDetailsByID(ID);
                // var cultureobj2 = name.Trim();

                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }




    }

}
