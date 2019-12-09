using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExamFinalCountDown.Models
{
    public class Exams
    {
        [Key]
        public int? Id { get; set; }
        public string ExamSubject { get; set; }

        [DisplayName("Start Time")]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:MM}")]
        public DateTime StartTime { get; set; }

        [DisplayName("Exam Date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:DD/MM/YYYY}")]
        public DateTime ExamDate { get; set; }

        public string Duration { get; set; }

        public string ClassRoom { get; set; }

        public string Faculty { get; set; }

        public ExamStatus Status { get; set; }

        public enum ExamStatus
        {
            done = 1,
            upcoming = 0,
            ongoing = -1,
        }
    }
}