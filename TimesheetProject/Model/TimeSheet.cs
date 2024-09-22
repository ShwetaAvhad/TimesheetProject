using System.ComponentModel.DataAnnotations;

namespace TimesheetProject.Model
{
    public class TimeSheet
    {
        [Key]
        public int TimesheetId {  get; set; }
        public DateTime DateTime { get; set; }
        public string OnLeave {  get; set; }
        public List<Activity> Activities { get; set; }=new List<Activity>(){ };
        
    }
}
