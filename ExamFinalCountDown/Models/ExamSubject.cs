using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExamFinalCountDown.Models
{
    public class ExamSubject
    {
        public int? ExamSubjectId { get; set; }
        public string ExamSubjectName { get; set; }

        public virtual ICollection<Exams> Exams { get; set; }
    }
}