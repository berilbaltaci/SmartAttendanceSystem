using System.ComponentModel.DataAnnotations.Schema;

namespace Comp4920_SAS.Models
{
    [Table("CourseStudent")]
    public class CourseStudent
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int AttendanceSum { get; set; }
        public int AttendanceSituation { get; set; }

    }
}