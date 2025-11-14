using School_Management_System.SecurityModels;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School_Management_System.Models
{
    public class Messages
    {
        [Key]
        public int Id { get; set; }

        public string Message { get; set; } = default!;


        public DateTime TimeStamp { get; set; }


        [DisplayName("Mark As")]
        [EnumDataType(typeof(Markas))]
        public Markas Markas { get; set; }


        [ForeignKey("Users")]
        public int SenderId { get; set; }

        [ForeignKey("Users")]
        public int ReceiverId { get; set; }

        //navigation
        public Users Users { get; set; } = default!;

      

    }
    public enum Markas
    {
        Read,Unread
    }
}
//message_id(PK)
//sender_id(FK)
//receiver_id(FK)
//message
//timestamp
//status (read/unread)