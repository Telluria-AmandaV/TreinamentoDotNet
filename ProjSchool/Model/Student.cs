using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProjEF.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        [Required]
        [Column("Name")]
        [MaxLength(50)]
        public string StudentName { get; set; }

        [Column(TypeName = "DateTime2")]
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
        public Grade Grade { get; set; }
        [Index("INDEX_REGNUM", IsClustered = true, IsUnique = true)]
        public int RegistrationNumber { get; set; }
    }
}