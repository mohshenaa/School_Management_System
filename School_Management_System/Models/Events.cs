using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace School_Management_System.Models
{
    public class Events
    {
        [Key]
        public int EventId { get; set; }

        public string Title { get; set; } = default!;

        public string Description { get; set; } = default!;

        [DisplayName("Event Date")]
        public DateTime EventDate { get; set; }

        public Audience Audience { get; set; }
    }
    public enum Audience
    {
        Student,
        Teacher,
        EveryOne
        
    }
}
//event_id(PK)
//title
//description
//event_date
//target_audience