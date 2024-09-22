using Microsoft.AspNetCore.Mvc;
using TimesheetProject.Model;

namespace TimesheetProject.Services
{
    public interface IActivityServices
    {
        public void AddActivity(Activity activity);
        public void AddActivityById(int id, Activity activity);
        public List<Activity> DisplayActivity();
        public Activity GetActivity(int id);
        public void DeleteActivity(int id);
        public void UpdateActivity( Activity activity);

        //methods for dropdown
        public void AddProject([FromBody] Project project);
        public List<Project> DisplayProject();
        public void AddSubProject([FromBody] SubProject subProject);
        public List<SubProject> DisplaySubProject();
        public void AddBatch([FromBody] Batch batch);
        public List<Batch> DisplayBatch();
    }
}
