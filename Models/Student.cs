using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Design;

namespace Comp4920_SAS.Models
{
    [Table("Student")]
    public class Student
    {
        public int StudentId { get; set; }
        public int UserId { get; set; }
        public int FingerprintId { get; set; }
        public string CardId { get; set; }
        public int FacultyId { get; set; }
        public int DepartmentId { get; set; }
        public int Class { get; set; }
        public double Gpa { get; set; }
    }
}