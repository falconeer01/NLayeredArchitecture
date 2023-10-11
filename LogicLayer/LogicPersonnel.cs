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

        public static int LLAddPersonnel(EntityPersonnel p)
        {
            string name = p.Name;
            string surname = p.Surname;
            string city = p.City;
            string duty = p.Duty;
            string salary = p.Salary.ToString();

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
            int id = p.ID;

            return DALPersonnel.DelPersonnel(id);
        }
    }
}
