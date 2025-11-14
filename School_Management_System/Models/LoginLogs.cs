using School_Management_System.SecurityModels;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School_Management_System.Models
{
    [Table("Login Logs")]
    public class LoginLogs
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Users")]
        public int UserId { get; set; }

       
        public DateTime LoginTime { get; set; }

        [DisplayName("Ip Address")]
        public string IpAddress { get; set; } = default!;///eta kemne ashbe?

        public Users Users { get; set; } = default!;
    }
}
//id(PK)
//user_id(FK)
//login_time
//ip_address