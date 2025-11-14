using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School_Management_System.Models
{
    [Table("Transport Routes")]
    public class TransportRoutes
    {
        [Key]
        public int RouteId { get; set; }

        [DisplayName("Route Name")]
        public string RouteName { get; set; } = default!;

        [DisplayName("Vehicle No")]
        public string VehicleNo { get; set; } = default!;

        [DisplayName("Driver Name")]
        public string DriverName { get; set; } = default!;

        public string Stops {  get; set; } = default!;
    }
}

//route_id(PK)
//route_name
//vehicle_no
//driver_name
//stops