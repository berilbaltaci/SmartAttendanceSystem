using System.ComponentModel.DataAnnotations.Schema;

namespace Comp4920_SAS.Models
{
    [Table("CourseTeacher")]
    public class CourseTeacher
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int TeacherId { get; set; }
    }
}