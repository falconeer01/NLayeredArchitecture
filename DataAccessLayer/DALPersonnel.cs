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

                return newPersonnel.ID; // Eklendikten sonraki ID'yi dönebilirsiniz.
            }
            catch (Exception ex)
            {
                // Hata durumunda burada işlem yapabilirsiniz.
                Console.WriteLine("Hata: " + ex.Message);
                return -1; // Hata durumunu belirtmek için -1 veya başka bir değer dönebilirsiniz.
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
                Console.WriteLine("Hata: " + ex.Message);
                return -1;
            }
        }
    }
}