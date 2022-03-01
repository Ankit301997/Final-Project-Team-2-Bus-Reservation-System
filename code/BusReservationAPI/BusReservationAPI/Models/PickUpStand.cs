using System;
using System.Collections.Generic;

namespace BusReservationAPI.Models​
{
    public partial class PickUpStand
    {
        public int StandId { get; set; }
        public int? RouteId { get; set; }
        public string? PlaceName { get; set; }
        public string? PlaceTime { get; set; }
        public int? BusId { get; set; }
    }
}
