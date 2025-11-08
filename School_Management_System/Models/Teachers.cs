using School_Management_System.Models;
using System.ComponentModel.DataAnnotations;

namespace School_Management_System.Models
{
    public class Teachers
    {
        [Key]
        public int TeacherId { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 3)]
        public string TeacherName { get;set;}=default!;

        [Required]
        public int UserId { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime JoiningDate { get; set; }

        [Required]
        public string Qualification { get; set; }=default!;


        [Required]
        public string Designation { get; set; }=default!;

        [Required]
        public Users User { get; set; }=new();

        [Required]
        public Departments Department { get; set; }=new();
     


    }

}

//teacher_id(PK)
//user_id(FK → Users)
//department_id
//joining_date
//qualification
//designation


