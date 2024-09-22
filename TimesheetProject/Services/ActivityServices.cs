using Microsoft.AspNetCore.Mvc;
using TimesheetProject.Model;
using TimesheetProject.Repository;

namespace TimesheetProject.Services
{
    public class ActivityServices : IActivityServices
    {
        public IActivityRepository activityRepository;
        public ActivityServices(IActivityRepository activityRepository)
        {
            this.activityRepository = activityRepository;
        }
        public void AddActivity([FromBody] Activity activity)
        {
            activityRepository.Add(activity);
        }
        public void AddActivityById(int id, Activity activity)
        {
            activityRepository.Add(id,activity);
        }
        public List<Activity> DisplayActivity()
        {
            return activityRepository.DisplayA();
        }
        public Activity GetActivity(int id)
        {
            return activityRepository.Find(id);
        }
        public void DeleteActivity(int id)
        {
            activityRepository.Delete(id);
        }
        public void UpdateActivity(Activity activity)
        {
            activityRepository.Update(activity);
        }


        //methods for dropdown
        public void AddProject([FromBody] Project project)
        {
            activityRepository.Add(project);
        }
        public void AddSubProject([FromBody] SubProject subProject)
        {
            activityRepository.Add(subProject);
        }
        public void AddBatch([FromBody] Batch batch)
        {
            activityRepository.Add(batch);
        }

        public List<Project> DisplayProject()
        {
            return activityRepository.DisplayP();
        }

        public List<SubProject> DisplaySubProject()
        {
            return activityRepository.DisplayS();
        }

        public List<Batch> DisplayBatch()
        {
            return activityRepository.DisplayB();
        }
        
    }
}
