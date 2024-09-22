using System.ComponentModel.DataAnnotations;

namespace TimesheetProject.Model
{
    public class Project
    {
        [Key]
        public int ProjectTd { get; set; }
        public string ProjetName {  get; set; }
    }
}
