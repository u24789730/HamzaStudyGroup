using HamzaStudyGroup.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HamzaStudyGroup.Controllers
{
    public class StudyGroupController : Controller
    {
        // GET: StudyGroup
        public ActionResult Index()
        {
            var members = new List<StudyGroupMember>
            {
                new StudyGroupMember { StudentNumber = "u24789730", Name = "Hamza", Surname = "Suleman", Email = "u24789730@tuks.co.za" },
                new StudyGroupMember { StudentNumber = "u05187720", Name = "Josh", Surname = "Miller", Email = "u05187720@tuks.co.za" },
                new StudyGroupMember { StudentNumber = "u21515795", Name = "Tatenda", Surname = "Mafigu", Email = "u21515795@tuks.co.za" },
                new StudyGroupMember { StudentNumber = "u24607194", Name = "Remoratile", Surname = "Smith", Email = "u24607194@tuks.co.za" },
                new StudyGroupMember { StudentNumber = "u24681556", Name = "Ntsika", Surname = "Patel", Email = "u24681556@tuks.co.za" }
            };

            return View(members);
        }
    }
}