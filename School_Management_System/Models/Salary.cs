using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School_Management_System.Models
{
    public class Salary
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Teachers")]
        public int TeacherId { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 3)]
        public string Month { get; set; } = default!;

        [Required]
        public decimal Amount { get; set; }

        public PaymentStatus paymentStatus { get; set; }    

        public Teachers Teachers { get; set; }= default!;

    }
    public enum PaymentStatus
    {
        Paid,UnPaid
    }
}
//salary_id(PK)
//teacher_id(FK)
//month
//amount
//payment_status

