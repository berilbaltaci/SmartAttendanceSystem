using System.ComponentModel.DataAnnotations.Schema;

namespace Comp4920_SAS.Models
{
    [Table("Teacher")]
    public class Teacher
    {
        public int TeacherId { get; set; }
        public int UserId { get; set; }
        public int CardId { get; set; }
        public int FacultyId { get; set; }
        public int DepartmentId { get; set; }
    }
}