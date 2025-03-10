using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HamzaStudyGroup.Models
{
    public class StudyGroupMember
    {
        [Display(Name = "Student Number")]
        public string StudentNumber { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Profile Link")]
        public string myLink { get; set; }
    }
}



