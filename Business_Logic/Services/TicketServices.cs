using BusinessLogic.BOs;
using DataLayer;
using DataLayer.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class TicketServices
    {
        public static List<TicketModel> GetAll()
        {

            var data = DataFactory.TicketRepo().GetAll();
            List<TicketModel> ticket = new List<TicketModel>();
            foreach (var d in data)
            {
                ticket.Add(new TicketModel { Category = d.Category, SeatType = d.SeatType, CompertmentId = d.CompertmentId, ClassId = d.ClassId, SeatId = d.SeatId });
            }
            return ticket;
        }

        public static TicketModel GetById(int id)
        {

            var data = DataFactory.TicketRepo().Get(id);
            if (data == null)
                return null;
            return new TicketModel
            {
                Category = data.Category,
                SeatType = data.SeatType,
                CompertmentId = data.CompertmentId,
                ClassId = data.ClassId,
                SeatId = data.SeatId
            };
        }

        public static bool Create(TicketModel obj)
        {
            Ticket t = new Ticket { Category = obj.Category, SeatType = obj.SeatType, CompertmentId = obj.CompertmentId, ClassId = obj.ClassId, SeatId =obj.SeatId };
            var res = DataFactory.TicketRepo().Create(t);
            return res;
        }

        public static bool Update(TicketModel obj)
        {
            Ticket t = new Ticket { Category = obj.Category, SeatType = obj.SeatType, CompertmentId = obj.CompertmentId, ClassId = obj.ClassId, SeatId =obj.SeatId };
            return DataFactory.TicketRepo().Update(t);
        }

        public static bool Delete(int id)
        {
            return DataFactory.TicketRepo().Delete(id);
        }

        //Ticket Services

    }
}
