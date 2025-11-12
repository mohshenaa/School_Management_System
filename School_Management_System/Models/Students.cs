using School_Management_System.Models;
using School_Management_System.SecurityModels;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School_Management_System.Models
{
    public class Students
    {
        [Key]
        public int StudentId { get; set; }


        [Required]
        [ForeignKey("Users")]
        public int UserId { get; set; }


        [Required]
        [ForeignKey("Classes")]
        public int ClassId { get; set; }

        [Required]
        [ForeignKey("Departments")]
        public int DepartmentId { get; set; }
        public Departments Departments { get; set; } = default!;

        [Required]
        [ForeignKey("Sections")]
        public int SectionId { get; set; }

        [Required(ErrorMessage = "Student Name is required")]
        [StringLength(40, MinimumLength = 3)]
        [Display(Name = "Student Name")]
        public string StudentName { get; set; } = default!;


        [Required]
        [Display(Name = "Roll No")]
        public int RollNo { get; set; }


        [Required]
        [EnumDataType(typeof(Gender))]
        public Gender Gender { get; set; }


        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Of Birth")]
        public DateTime Dob { get; set; }


        
        [EnumDataType(typeof(BloodGroup))]
        public BloodGroup BloodGroup { get; set; }


        [DataType(DataType.ImageUrl)]
        public string? ImageUrl { get; set; }


        [NotMapped, Display(Name = "Image")]
        public IFormFile? ImageFile { get; set; }


        [Required]
        [StringLength(40, MinimumLength = 3)]
        [Display(Name = "Guardian Name")]
        public string GuardianName { get; set; } = default!;


   
        public string Address { get; set; } = default!;


        [Display(Name = "Phone Number")]
        [Column("PhoneNumber")]
        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage = "Please enter a valid phone number")]
        public string Contact { get; set; } = default!;


        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime AdmissionDate { get; set; }

        //all nevigation links
        public Users? Users { get; set; }


        [Required]  
        public Classes Classes { get;set;} = default!;

        [Required]
        public Sections Sections { get; set; } = default!;



    }
    public enum Gender
    {
        Male,
        Female
    }
    public enum BloodGroup
    {
        A_Positive,
        A_Negative,
        B_Positive,
        B_Negative,
        AB_Positive,
        AB_Negative,
        O_Positive,
        O_Negative
    }
}

//student_id(PK)
//user_id(FK → Users)
//class_id(FK → Classes)
//section_id(FK → Sections)
//roll_no
//gender
//dob
//blood_group
//guardian_name
//address
//admission_date


