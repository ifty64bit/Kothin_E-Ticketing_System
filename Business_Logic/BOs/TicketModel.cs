using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.BOs
{
    public class TicketModel
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string SeatType { get; set; }
        public int CompertmentId { get; set; }
        public int ClassId { get; set; }
        public int SeatId { get; set; }
    }
}
