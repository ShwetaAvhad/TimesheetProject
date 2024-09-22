using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TimesheetProject.Data;
using TimesheetProject.Model;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace TimesheetProject.Repository
{
    public class ActivityRepository : IActivityRepository
    {
        public ActivityDbContext activityDbContext;
        public ActivityRepository(ActivityDbContext activityDbContext)
        {
            this.activityDbContext = activityDbContext;
        }

        public void Add(Activity activity)
        {
            activityDbContext.Activities.Add(activity);
            activityDbContext.SaveChanges();
        }
        public void Add(int id, Activity activity)
        {
            var timesheet=activityDbContext.TimeSheets.Include(x =>x.Activities).SingleOrDefault(x=>x.TimesheetId==id);
            activity.TimesheetId = id;
            timesheet.Activities.Add(activity);
            activityDbContext.SaveChanges();
        }
        public List<Activity> DisplayA()
        {
            return activityDbContext.Activities.ToList();
        }
        public Activity Find(int id)
        {
            return activityDbContext.Activities.Find(id);
        }
        public void Delete(int id)
        {
            Activity activity = activityDbContext.Activities.Find(id);
            activityDbContext.Activities.Remove(activity);
            activityDbContext.SaveChanges();
        }

        public void Update(Activity activity)
        {
            var activity1 = activityDbContext.Activities.Find(activity.ActivityId);
            
            if(activity1 != null)
            {
                activity1.Project = activity.Project;
                activity1.SubProject = activity.SubProject;
                activity1.Batch = activity.Batch;
                activity1.Time = activity.Time;
                activity1.ActivityDesc = activity.ActivityDesc;
                activityDbContext.SaveChanges();
            }   
        }




        //methods for dropdown
        public void Add(Project project)
        {
            activityDbContext.Projects.Add(project);
            activityDbContext.SaveChanges();
        }

        public void Add(SubProject subProject)
        {
            activityDbContext.SubProjects.Add(subProject);
            activityDbContext.SaveChanges();
        }

        public void Add(Batch batch)
        {
            activityDbContext.Batches.Add(batch);
            activityDbContext.SaveChanges();
        }

        public List<Project> DisplayP()
        {
            return activityDbContext.Projects.ToList();
        }

        public List<SubProject> DisplayS()
        {
            return activityDbContext.SubProjects.ToList();
        }

        public List<Batch> DisplayB()
        {
            return activityDbContext.Batches.ToList();
        }
    }
}
