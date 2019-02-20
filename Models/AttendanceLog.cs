using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Comp4920_SAS.Models
{
    [Table("AttendanceLog")]
    public class AttendanceLog
    {
        [Key]
        public int LogId { get; set; }
        public int CourseStudentId { get; set; }
        public string Date { get; set; }
        public int IsSchoolCard { get; set; }
        public int IsFingerprint { get; set; }
        public int IsOnline { get; set; }
        public int TeacherId { get; set; }
    }
}