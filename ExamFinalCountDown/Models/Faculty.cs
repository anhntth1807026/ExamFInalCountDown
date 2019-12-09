using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExamFinalCountDown.Models
{
    public class Faculty
    {
        [Key]
        public int? FacultyId { get; set; }
        public string FacultyName { get; set; }

        public virtual ICollection<Exams> Exams { get; set; }
    }
}