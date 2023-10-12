using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicPersonnel
    {
        public static List<EntityPersonnel> LLPersonnelList()
        {
            return DALPersonnel.PersonnelList();
        }

        public static int LLAddPersonnel(EntityPersonnel p, string name, string surname, string city, string duty, string salary)
        {
            if (p.Name != "")
            {
                return DALPersonnel.AddPersonnel(name, surname, city, duty, salary);
            }
            else
            {
                return -1;
            }
        }

        public static int LLDelPersonnel(EntityPersonnel p)
        {
            return DALPersonnel.DelPersonnel(p.ID);
        }

        public static int LLUpdatePersonnel(EntityPersonnel p, int id, string name, string surname, string city, string duty, string salary)
        {
            if (p.Name != "")
            {
                return DALPersonnel.UpdatePersonnel(id, name, surname, city, duty, salary);
            }
            else
            {
                return -1;
            }
        }
    }
}
