using System.ComponentModel.DataAnnotations;

namespace School_Management_System.Models
{
    public class Departments
    {
        [Key]
        public int DepartmentId { get; set; }
        public ICollection<Students> Students { get; set; }
    }
}