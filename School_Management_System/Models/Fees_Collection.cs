using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School_Management_System.Models
{
    [Table("Fees Collection")]
    public class Fees_Collection
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Students")]
        public int StudentId { get; set; }

        [Required]
        [ForeignKey("Fees_Types")]
        public int FeesTypeId { get; set; }

        [Required]
        [DataType("money")]
        
        public decimal PaidAmount { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PaidDate { get; set; }

        [Required]
        public string PaymentMethod { get; set; } = default!;

        [Required]
        [EnumDataType(typeof(FeesStatus))]
        public FeesStatus Status { get; set; }  

        public Students Students { get; set; }= default!;
        public Fees_Types Fees_Types { get; set; } = default!;
    }
    public enum FeesStatus
    {
        Paid, UnPaid
    }
}
//id(PK)
//student_id(FK)
//fee_type_id(FK)
//amount_paid
//date_paid
//payment_method
//status (paid/unpaid)
