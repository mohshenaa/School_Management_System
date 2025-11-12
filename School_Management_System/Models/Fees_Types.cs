using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School_Management_System.Models
{
    public class Fees_Types
    {
        [Key]
        public int FeesTypeId { get; set; }

        [Required]
        [ForeignKey("Classes")]
        public int ClassId { get; set; }

        [Required]
        public string FeesName { get; set; } = default!;

        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }

        public Frequency Frequency { get; set; }

        public Classes Classes { get; set; } = default!;


    }
    public enum Frequency
    {
        Monthly, Yearly,
    }
}

//fee_type_id(PK)
//class_id(FK)
//name
//amount
//frequency (monthly/yearly)
