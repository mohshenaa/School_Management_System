using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Xml;
using System.Xml.Linq;

namespace School_Management_System.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(40,MinimumLength =3)]
        public string Name { get; set; } = default!;


        [Required]
        [EmailAddress]
        public string Email { get; set; } = default!;


        [Required]
    //    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*><?/|\\+\-*]).{8,}$",
    //ErrorMessage = "Password must be at least 8 characters and include [a-z], [A-Z], [0-9], and one special [!@#$%^&*><?/|\\+-*].")]
        [RegularExpression(@"^[a-zA-Z0-9!@#$%^&*><?/|+\-*/]{8,}$",
            ErrorMessage = "Password must be at least 8 characters long and include at least one uppercase letter, one lowercase letter, one number, and one special character")]
        public string Password { get; set; } = default!;


        [Required]
        [ForeignKey("Roles")]
        public int RoleId { get; set; }

        [Required]
        public string Status { get; set; } = default!;

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedAt { get; set; }=DateTime.Now;


        [Required]
        public Roles Role { get; set; } = new();
            

    }
}
//user_id(PK)
//name
//email(unique)
//password
//role_id(FK → Roles)
//status
//created_at