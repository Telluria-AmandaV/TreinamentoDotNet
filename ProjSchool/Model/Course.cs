using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolProjEF.Model
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }

        [ForeignKey("OnlineTeacher")]
        public int? OnlineTeacherId { get; set; }
        public Teacher OnlineTeacher { get; set; }

        [ForeignKey("ClassRoomTeacher")]
        public int? ClassRoomTeacherId { get; set; }
        public Teacher ClassRoomTeacher { get; set; }
    }
}
