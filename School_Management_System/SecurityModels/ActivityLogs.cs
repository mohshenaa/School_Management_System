using School_Management_System.SecurityModels;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School_Management_System.Models
{
    [Table("Activity Logs")]
    public class ActivityLogs
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Users")]
        public int UserId { get; set; }


        [DisplayName("Action Type")]
        public string ActionType { get; set; } = default!;

        public string Description { get; set; } = default!;

        public DateTime TimeStamp { get; set; }

        //navigation
        public Users Users { get; set; } = default!;
    }
}
//id(PK)
//user_id(FK)
//action_type
//description
//timestamp