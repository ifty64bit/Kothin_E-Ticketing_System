using DataLayer.EF;
using DataLayer.Interfaces;
using DataLayer.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataFactory
    {
        static readonly ETicketEntities db = new ETicketEntities();

        public static IRepo<Train, int> TrainRepo()
        {
            return new TrainRepo(db);
        }

        public static IRepo<Train_Schedules, int> Train_ScheduleRepo()
        {
            return new Train_ScheduleRepo(db);
        }

        public static IRepo<Train_Stations, int> Train_StationRepo()
        {
            return new Train_StationRepo(db);
        }
    }
}
