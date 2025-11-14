using School_Management_System.SecurityModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School_Management_System.Models
{
    public class Notice
    {
        [Key]
        public int Id { get; set; }

    
        public string Title { get; set; } = default!;


    
        public string Content { get; set; }= default!;


        [Required]
        [ForeignKey("Roles")]
        public int RoleId { get; set; }


        public DateTime Posted {  get; set; }

        //navigation link
        public Roles Roles { get; set; } = default!;

       
        //[NotMapped]
        //public string? DisplayRoleName => Roles?.RoleName.ToString(); // to show role name


    }
}
//notice_id(PK)
//title
//content
//visible_to (role_id)
//date_posted
