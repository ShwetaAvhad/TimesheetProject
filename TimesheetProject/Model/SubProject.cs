using System.ComponentModel.DataAnnotations;

namespace TimesheetProject.Model
{
    public class SubProject
    {
        [Key]
        public int SubProjectTd { get; set; }
        public string SubProjetName { get; set; }
    }
}
