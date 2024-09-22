using Microsoft.AspNetCore.Mvc;
using TimesheetProject.Model;
using TimesheetProject.Services;


namespace TimesheetProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimesheetController : ControllerBase
    {
        public ITimesheetService timesheetService;
        public TimesheetController(ITimesheetService timesheetService)
        {
            this.timesheetService = timesheetService;
        }

        [HttpGet("Timesheet")]
        public IEnumerable<TimeSheet> Get()
        {
            return timesheetService.DisplayTimesheet();
        }

        [HttpPost("Timesheet")]
        public void Post([FromBody] TimeSheet timeSheet)
        {
            timesheetService.AddTimesheet(timeSheet);
        }
        [HttpGet("Timesheet{id}")]
        public TimeSheet Get(int id)
        {
            return timesheetService.GetTimesheet(id);
        }
        [HttpPut("Timesheet")]
        public void Put(int id, [FromBody] TimeSheet timeSheet)
        {
            timesheetService.UpdateTimesheet(id,timeSheet);
        }
        [HttpDelete("Timesheet{id}")]
        public void Delete(int id)
        {
            timesheetService.DeleteTimesheet(id);
        }



    }
}













//// GET api/<TimesheetController>/5
//[HttpGet("{id}")]
//public string Get(int id)
//{
//    return "value";
//}

//// PUT api/<TimesheetController>/5
//[HttpPut("{id}")]
//public void Put(int id, [FromBody] string value)
//{
//}

//// DELETE api/<TimesheetController>/5
//[HttpDelete("{id}")]
//public void Delete(int id)
//{
//}
