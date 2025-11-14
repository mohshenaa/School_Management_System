using System.ComponentModel.DataAnnotations;

namespace School_Management_System.Models
{
    public class Hostel
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = default!;

        public int Capacity { get; set; }

        public string WardenInfo { get; set; } = default!;

        public List<HostelResidents> HostelResidents { get; set; } = new();
    }
}
//hostel_id(PK)
//name
//capacity
//warden_info
