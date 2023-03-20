


using Microsoft.AspNetCore.Mvc;

namespace EmployeeApi.Controllers
{
    public class EmployeeController : ControllerBase
    {
        // GET /employees    
        [HttpGet("/employees")]
        //public async Task<ActionResult> GetAllEmployees([FromQuery(Name ="department_name")]string dept= "ALL") /* url in Postman: http://localhost:1338/employees?department_name=DEV */
        public async Task<ActionResult> GetAllEmployees([FromQuery] string dept = "ALL")
        {
            var response = new EmployeeSummaryResponse(18, 10, 8, dept);
            return Ok(response);
        }
    }
}
