using System;
using System.Collections.Generic;

namespace BusReservationAPI.Models​
{
    public partial class Pnrdetail
    {
        public long PnrdetailsId { get; set; }
        public string? Pnrno { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? TotalTickets { get; set; }
        public int? CreatedBy { get; set; }
    }
}
