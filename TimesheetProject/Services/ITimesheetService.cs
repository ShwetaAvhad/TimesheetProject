using Microsoft.AspNetCore.Mvc;
using TimesheetProject.Model;

namespace TimesheetProject.Services
{
    public interface ITimesheetService
    {
        public void AddTimesheet([FromBody] TimeSheet timeSheet);
        public List<TimeSheet> DisplayTimesheet();
        public TimeSheet GetTimesheet(int id);
        public void UpdateTimesheet(int id, TimeSheet timeSheet);
        public void DeleteTimesheet(int id);

    }
}
