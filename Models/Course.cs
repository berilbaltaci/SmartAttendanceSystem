using System.ComponentModel.DataAnnotations.Schema;

namespace Comp4920_SAS.Models
{
    [Table("Course")]
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public int Quota { get; set; }
        public string Year { get; set; }
        public string Term { get; set; }
        public int LecturePerWeek { get; set; }
        
    }
}