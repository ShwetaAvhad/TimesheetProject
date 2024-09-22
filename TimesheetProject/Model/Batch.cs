using System.ComponentModel.DataAnnotations;

namespace TimesheetProject.Model
{
    public class Batch
    {
        [Key]
        public int BatchTd {  get; set; }
        public string BatchName { get; set; }
    }
}
