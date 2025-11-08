using School_Management_System.Models;
using System.ComponentModel.DataAnnotations;

namespace School_Management_System.Models
{
    public class Roles
    {
        [Key]
        public int RoleId { get; set; }


        [Required]
        [StringLength(40, MinimumLength = 3)]
        [EnumDataType(typeof(Role))]
        public Role RoleName { get; set; } 
    }

    public enum Role
    {
        Admin,
        Teacher,
        Student,
        Parent
    }
}
//role_id(PK)
//role_name(Admin, Teacher, Student, Parent)


//Relation:
//-Users.role_id → Roles.role_id
