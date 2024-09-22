using Microsoft.AspNetCore.Mvc;
using TimesheetProject.Model;
using TimesheetProject.Repository;

namespace TimesheetProject.Services
{
    public class TimesheetService : ITimesheetService
    {
        public ITimesheetRepository timesheetRepository;
        public TimesheetService(ITimesheetRepository timesheetRepository)
        {
            this.timesheetRepository = timesheetRepository;
        }
        public void AddTimesheet([FromBody] TimeSheet timeSheet)
        {
            timesheetRepository.Add(timeSheet);
        }
        public List<TimeSheet> DisplayTimesheet()
        {
            return timesheetRepository.Display();
        }
        public TimeSheet GetTimesheet(int id)
        {
            return timesheetRepository.Find(id);
        }
        public void UpdateTimesheet(int id, TimeSheet timeSheet)
        {
            timesheetRepository.Update(id, timeSheet);
        }
        public void DeleteTimesheet(int id)
        {
            timesheetRepository.Delete(id);
        }

    }
}
