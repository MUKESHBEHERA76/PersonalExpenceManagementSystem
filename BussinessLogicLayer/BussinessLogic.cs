using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class BussinessLogic
    {
        Entity entity = new Entity();
        public bool ValidateData(Entity entity)
        {
            bool Added = true;
            if (entity.Grocery != 0 && entity.Grocery <= 2000)
            {
                Added = true;
            }
            if (entity.Medical != 0 && entity.Medical <= 2000)
            {
                Added = true;
            }
            if (entity.Personal != 0 && entity.Personal <= 2000)
            {
                Added = true;
            }
            if (entity.Rent != 0 && entity.Rent <= 2000)
            {
                Added = true;
            }
            if (entity.EMI != 0 && entity.EMI <= 2000)
            {
                Added = true;
            }
            if (entity.Travelling != 0 && entity.Travelling <= 2000)
            {
                Added = true;
            }
            return Added;
        }
        public bool AddList(Entity budget)
        {
            bool Added = true;
            if (ValidateData(budget))
            {
                Database.ListSerialize(budget);
            }
            else
            {
                Added = false;
            }
            return Added;
        }
        public bool ValidateMonth(Entity entity)
        {
            bool added = true;
            if (entity.Month.Equals("jan") ||
                entity.Month.Equals("JAN") ||
                entity.Month.Equals("feb") ||
                entity.Month.Equals("FEB") ||
                entity.Month.Equals("MAR") ||
                entity.Month.Equals("mar") ||
                entity.Month.Equals("apr") ||
                entity.Month.Equals("APR") ||
                entity.Month.Equals("may") ||
                entity.Month.Equals("MAY") ||
                entity.Month.Equals("jun") ||
                entity.Month.Equals("JUN") ||
                entity.Month.Equals("JUL") ||
                entity.Month.Equals("jul") ||
                entity.Month.Equals("aug") ||
                entity.Month.Equals("AUG") ||
                entity.Month.Equals("sep") ||
                entity.Month.Equals("SEP") ||
                entity.Month.Equals("oct") ||
                entity.Month.Equals("OCT") ||
                entity.Month.Equals("nov") ||
                entity.Month.Equals("NOV") ||
                entity.Month.Equals("DEC") ||
                entity.Month.Equals("dec"))
            {
                added = true;
            }
            else
            {
                added = false;
            }
            return added;
        }

        public bool CheckMonth(Entity budget)
        {
            bool Added = true;
            if (ValidateMonth(budget))
            {
                List<Entity> month = Database.ListDeserializer();
                if (month.Count.Equals(null))
                    Added = true;
            }
            else
            {
                Added = false;
            }
            return Added;
        }
        public Entity SearchBymonth(string search)
        {
            List<Entity> month = Database.ListDeserializer();
            Entity entity = month.Find(temp => temp.Month == search);
            return entity;
        }
    }
}
