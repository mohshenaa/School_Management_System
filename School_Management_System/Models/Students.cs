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

        [Required]
        [StringLength(40, MinimumLength = 3)]
        public string StudentName { get; set; } = default!;


        [Required]
        public int RollNo { get; set; }


        [Required]
        [EnumDataType(typeof(Gender))]
        public Gender Gender { get; set; }


        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Dob { get; set; }


        [Required]
        [EnumDataType(typeof(BloodGroup))]
        public BloodGroup BloodGroup { get; set; }


        [Required]
        [StringLength(40, MinimumLength = 3)]
        public string GuardianName { get; set; } = default!;


        [Required]
        public string Address { get; set; } = default!;


        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime AdmissionDate { get; set; }


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


