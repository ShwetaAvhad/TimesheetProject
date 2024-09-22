using TimesheetProject.Model;

namespace TimesheetProject.Repository
{
    public interface ITimesheetRepository
    {
        public void Add(TimeSheet timeSheet);
        public List<TimeSheet> Display();
        public TimeSheet Find(int id);
        public void Update(int id, TimeSheet timeSheet);
        public void Delete(int id);
    }
}
