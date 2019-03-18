using System.ComponentModel.DataAnnotations.Schema;

namespace Comp4920_SAS.Models
{
    [Table("Session")]
    public class Session
    {
        public int Id { get; set; }
        public int LecturePerDay { get; set; }
        public string Date { get; set; }
        public int CourseTeacherId { get; set; }
    }
}