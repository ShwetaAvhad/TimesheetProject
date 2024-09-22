using Microsoft.AspNetCore.Mvc;
using TimesheetProject.Model;
using TimesheetProject.Services;


namespace TimesheetProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        public IActivityServices activityServices;
        public ActivityController(IActivityServices activityServices)
        {
            this.activityServices = activityServices;
        }

        [HttpGet("Activity")]
        public IEnumerable<Activity> GetActivity()
        {
            return activityServices.DisplayActivity();
        }

        [HttpPost("Activity")]
        public void Post([FromBody] Activity activity)
        {
            activityServices.AddActivity(activity);
        }
        [HttpPost("Activity{id}")]
        public void Post(int id, [FromBody] Activity activity)
        {
            activityServices.AddActivityById(id, activity);
        }
        [HttpGet("Activity{id}")]
        public Activity Get(int id)
        {
            return activityServices.GetActivity(id);
        }
        [HttpPut("Activity")]
        public void Put([FromBody] Activity activity)
        {
            activityServices.UpdateActivity(activity);
        }
        [HttpDelete("Activity{id}")]
        public void Delete(int id)
        {
            activityServices.DeleteActivity(id);
        }





        //methods for dropdown

        [HttpGet("Project")]
        public IEnumerable<Project> GetProjects()
        {
            return activityServices.DisplayProject();
        }

        [HttpPost("Project")]
        public void Post([FromBody] Project project)
        {
            activityServices.AddProject(project);
        }


        [HttpGet("SubProject")]
        public IEnumerable<SubProject> GetSubProjects()
        {
            return activityServices.DisplaySubProject();
        }

        [HttpPost("SubProject")]
        public void Post([FromBody] SubProject subProject)
        {
            activityServices.AddSubProject(subProject);
        }


        [HttpGet("Batch")]
        public IEnumerable<Batch> GetBatch()
        {
            return activityServices.DisplayBatch();
        }

        [HttpPost("Batch")]
        public void Post([FromBody] Batch batch)
        {
            activityServices.AddBatch(batch);
        }

    }
}
