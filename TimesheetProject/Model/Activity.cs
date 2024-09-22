using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace TimesheetProject.Model
{
    public class Activity
    {
        [Key]
        public int ActivityId { get; set; }
        public string Project { get; set; }
        public string SubProject { get; set; }
        public string Batch { get; set; }
        public string Time { get; set; }
        public string ActivityDesc { get; set; }
        [JsonIgnore]
        public int TimesheetId { get; set; }
        [JsonIgnore]
        [ValidateNever]
        public TimeSheet TimeSheet { get; set; }

    }
}
