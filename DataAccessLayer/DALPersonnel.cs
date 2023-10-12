using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALPersonnel
    {
        public static List<EntityPersonnel> PersonnelList()
        {
            List<EntityPersonnel> values = new List<EntityPersonnel>();

            var personnels = EFC.EFConnection.Personnel.ToList();

            foreach (var personnel in personnels)
            {
                EntityPersonnel EP = new EntityPersonnel()
                {
                    ID = Convert.ToInt32(personnel.ID),
                    Name = personnel.Name,
                    Surname = personnel.Surname,
                    City = personnel.City,
                    Duty = personnel.Duty,
                    Salary = Convert.ToInt16(personnel.Salary)
                };

                values.Add(EP);
            }

            return values;
        }

        public static int AddPersonnel(string name, string surname, string city, string duty, string salary)
        {
            try
            {
                EFConnection DB = new EFConnection();

                Personnel newPersonnel = new Personnel
                {
                    Name = name,
                    Surname = surname,
                    City = city,
                    Duty = duty,
                    Salary = Convert.ToInt16(salary)
                };

                DB.Personnel.Add(newPersonnel);
                DB.SaveChanges();

                return newPersonnel.ID;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return -1;
            }
        }

        public static int DelPersonnel(int id)
        {
            try
            {
                EFConnection DB = new EFConnection();

                var personnel = DB.Personnel.Find(id);

                DB.Personnel.Remove(personnel);
                DB.SaveChanges();

                return personnel.ID;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return -1;
            }
        }

        public static int UpdatePersonnel(int id, string name, string surname, string city, string duty, string salary)
        {
            try
            {
                EFConnection DB = new EFConnection();

                var personnel = DB.Personnel.Find(id);

                personnel.Name = name;
                personnel.Surname = surname;
                personnel.City = city;
                personnel.Duty = duty;
                personnel.Salary = short.Parse(salary);

                DB.SaveChanges();

                return personnel.ID;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return -1;
            }
        }
    }
}