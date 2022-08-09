using DataLayer.EF;
using DataLayer.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.Repo
{
    internal class AirplaneRepo : IRepo<Airplane, int>
    {
        ETicketEntities db;
        public AirplaneRepo(ETicketEntities db)
        {
            this.db = db;
        }
        public bool Create(Airplane obj)
        {
            try
            {
                db.Airplanes.Add(obj);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool CreateSchedule(Airple_Schedules obj)
        {
            try
            {
                db.Airple_Schedules.Add(obj);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                db.Airplanes.Remove((from n in db.Airplanes where n.Id == id select n).SingleOrDefault());
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteSchedule(int id)
        {
            try
            {
                db.Airple_Schedules.Remove((from n in db.Airple_Schedules where n.Id == id select n).SingleOrDefault());
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Airplane Get(int id)
        {
            return db.Airplanes.Find(id);
        }

        public List<Airplane> GetAll()
        {
            return db.Airplanes.ToList();
        }

        public List<Airple_Schedules> GetAllSchedules()
        {
            return db.Airple_Schedules.ToList();
        }

        public Airple_Schedules GetSchedule(int id)
        {
            return db.Airple_Schedules.Find(id);
        }

        public bool Update(Airplane obj)
        {
            Airplane old = db.Airplanes.Where(x => x.Id == obj.Id).SingleOrDefault();
            if (old != null)
            {
                db.Entry(old).CurrentValues.SetValues(obj);
                db.SaveChanges();
                return true;
            }
            return false;
        }



        public bool UpdateSchedule(Airple_Schedules obj)
        {
            Airple_Schedules old = db.Airple_Schedules.Where(x => x.Id == obj.Id).SingleOrDefault();
            if (old != null)
            {
                db.Entry(old).CurrentValues.SetValues(obj);
                db.SaveChanges();
                return true;
            }
            return false;
        }



        Airplane IRepo<Airplane, int>.Get(int id)
        {
            throw new System.NotImplementedException();
        }

        List<Airplane> IRepo<Airplane, int>.GetAll()
        {
            throw new System.NotImplementedException();
        }
    }


}
