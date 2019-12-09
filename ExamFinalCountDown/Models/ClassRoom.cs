using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExamFinalCountDown.Models
{
    public class ClassRoom
    {
        public int? ClassRoomId { get; set; }
        public string ClassRoomName { get; set; }

        public virtual ICollection<Exams> Exams { get; set; }
    }
}