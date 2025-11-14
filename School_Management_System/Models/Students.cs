public class Student
{
    [Key]
    public int StudentId { get; set; }


    [ForeignKey(nameof(User))]
    public int UserId { get; set; }
    public User User { get; set; } = default!;

    [Required, MaxLength(150)]
    public string StudentName { get; set; } = default!;   // English default name

    [MaxLength(150)]
    public string? ArabicStudentName { get; set; }        // optional

    [MaxLength(150)]
    public string? BanglaStudentName { get; set; }        // optional


    [ForeignKey(nameof(Class))]
    public int ClassId { get; set; }
    public Class Class { get; set; } = default!;

    [ForeignKey(nameof(Section))]
    public int SectionId { get; set; }
    public Section Section { get; set; } = default!;



    [Required, MaxLength(20)]
    [RegularExpression(@"^[A-Za-z0-9\-]+$", ErrorMessage = "Invalid Roll No format.")]
    public string RollNo { get; set; } = default!;

    [MaxLength(50)]
    public string? AdmissionNumber { get; set; }  // School generated

    [MaxLength(50)]
    public string? NationalId { get; set; }       // NID / Birth Certificate No

    public DateTimeOffset AdmissionDate { get; set; }



    public Gender? Gender { get; set; }
    public DateTimeOffset DOB { get; set; }

    [MaxLength(5)]
    public string? BloodGroup { get; set; }

    
    [MaxLength(150)]
    public string? FatherName { get; set; }      // Parents / Guardian Info

    [MaxLength(20)]
    public string? FatherPhone { get; set; }

    [MaxLength(150)]
    public string? MotherName { get; set; }

    [MaxLength(20)]
    public string? MotherPhone { get; set; }

    [MaxLength(150)]
    public string? GuardianName { get; set; }

    [MaxLength(20)]
    public string? GuardianPhone { get; set; }

    [MaxLength(150)]
    public string? GuardianEmail { get; set; }


    [MaxLength(500)]
    public string? Address { get; set; }

    [MaxLength(150)]
    public string? City { get; set; }

    [MaxLength(150)]
    public string? Country { get; set; }


    // Emergency Information

    [MaxLength(150)]
    public string? EmergencyContactName { get; set; }

    [MaxLength(20)]
    public string? EmergencyPhone { get; set; }

    [MaxLength(500)]
    public string? MedicalNotes { get; set; } // Allergies / Restrictions


    [MaxLength(250)]
    public string? PreviousSchoolName { get; set; }  // Academic History (optional)

    public double? PreviousGPA { get; set; }


    [MaxLength(300)]
    public string? ProfileImageUrl { get; set; }

    [MaxLength(300)]
    public string? DocumentUrl { get; set; } // Birth Cert, Transfer Cert, etc.


    public bool IsActive { get; set; } = true;

    public DateTimeOffset? LeavingDate { get; set; }

    [MaxLength(300)]
    public string? LeavingReason { get; set; }

  
    public Dictionary<string, string>? TranslatedNames { get; set; }  // Advanced Multilanguage (optional)


    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? UpdatedAt { get; set; }
}


// -------------------------
// ENUM
// -------------------------
public enum Gender
{
    Male,
    Female,
    Other,
    PreferNotToSay
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


