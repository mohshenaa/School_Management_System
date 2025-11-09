using System.ComponentModel.DataAnnotations;

namespace School_Management_System.Models
{
    public class Expenses
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ExpenseType { get; set; } = default!;


        [Required]
        public string Description { get; set; } = default!;


        [Required]
        public decimal Amount { get; set; }


        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date {  get; set; }
    }
}
//expense_id(PK)
//type
//description
//amount
//date

