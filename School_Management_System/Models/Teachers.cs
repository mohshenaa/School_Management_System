using School_Management_System.SecurityModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School_Management_System.Models
{
    public class Teachers
    {
        [Key]
        public int TeacherId { get; set; }


        [Required]
        [ForeignKey("Users")]
        public int UserId { get; set; }

        [Required]
        [ForeignKey("Departments")]
        public int DepartmentId { get; set; }


        [Required]
        [StringLength(40, MinimumLength = 3)]
        [Display(Name = "Teacher Name")]
        public string TeacherName { get;set;}=default!;



        [DataType(DataType.ImageUrl)]
        public string? ImageUrl { get; set; }


        [NotMapped, Display(Name = "Image")]
        public IFormFile? ImageFile { get; set; }



        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime JoiningDate { get; set; }

        [Required]
        public string Qualification { get; set; }=default!;


        [Required]
        public string Designation { get; set; }=default!;


        //navigation links
        
        public Users Users { get; set; } = default!;


        public Departments Departments { get; set; } = default!;



    }

}

//teacher_id(PK)
//user_id(FK → Users)
//department_id
//joining_date
//qualification
//designation


