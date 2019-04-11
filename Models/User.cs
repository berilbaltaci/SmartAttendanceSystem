using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace Comp4920_SAS.Models
 {
     [Table("User")]
     public class User
     {
         public int UserId { get; set; }
         public string SchoolId { get; set; }
         public string Name { get; set; }
         public string Surname { get; set; }
         public string Password { get; set; }
         public int UserRole { get; set; }
         public byte[] UserPhoto { get; set; }    
     }
 }