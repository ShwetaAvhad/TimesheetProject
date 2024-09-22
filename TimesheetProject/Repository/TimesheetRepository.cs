using Microsoft.EntityFrameworkCore;
using TimesheetProject.Data;
using TimesheetProject.Model;

namespace TimesheetProject.Repository
{
    public class TimesheetRepository : ITimesheetRepository
    {
        public ActivityDbContext activityDbContext;
        public TimesheetRepository(ActivityDbContext activityDbContext)
        {
            this.activityDbContext = activityDbContext;
        }
        public void Add(TimeSheet timeSheet)
        {
            activityDbContext.TimeSheets.Add(timeSheet);
            activityDbContext.SaveChanges();
        }
        public List<TimeSheet> Display()
        {
            //return activityDbContext.TimeSheets.ToList();
            return activityDbContext.TimeSheets.Include(x=>x.Activities).ToList();
        }
        public TimeSheet Find(int id)
        {
            return activityDbContext.TimeSheets.Include(x=>x.Activities).FirstOrDefault(x=>x.TimesheetId==id);
        }
       
        public void Update(int id, TimeSheet timeSheet)
        {
            TimeSheet timeSheet1 = activityDbContext.TimeSheets.Include(x => x.Activities).FirstOrDefault(x => x.TimesheetId == id);

            if (timeSheet1 == null)
            {
                throw new ArgumentException("Timesheet not found.");
            }

            timeSheet1.DateTime = timeSheet.DateTime;
            timeSheet1.OnLeave = timeSheet.OnLeave;

            foreach (var activity in timeSheet.Activities)
            {
                var activity1 = timeSheet1.Activities.FirstOrDefault(a => a.ActivityId == activity.ActivityId);

                if (activity1 != null)
                {
                    activity1.Project = activity.Project;
                    activity1.SubProject = activity.SubProject;
                    activity1.Batch = activity.Batch;
                    activity1.Time = activity.Time;
                    activity1.ActivityDesc = activity.ActivityDesc;
                }
            }

            activityDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            TimeSheet timeSheet = activityDbContext.TimeSheets.Include(x => x.Activities).FirstOrDefault(x => x.TimesheetId == id);
            activityDbContext.Remove(timeSheet);
            activityDbContext.SaveChanges();
        }

    }
}
