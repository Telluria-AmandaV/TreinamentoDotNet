using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolProjEF.Model
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }

        [InverseProperty("OnlineTeacher")]
        public ICollection<Course> OnlineCourses { get; set; }

        [InverseProperty("ClassRoomTeacher")]
        public ICollection<Course> ClassRoomCourses { get; set; }
    }
}
