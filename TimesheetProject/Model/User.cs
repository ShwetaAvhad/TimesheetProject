﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TimesheetProject.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        [NotMapped]
        public string UserMessage { get; set; }
        [NotMapped]
        public string AccessToken { get; set; }
    }
}
