using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;
using DataAccessLayer;
using EntityLayer;

namespace NLayeredArchitecture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<EntityPersonnel> PerList = LogicPersonnel.LLPersonnelList();
            DataPanel.DataSource = PerList;
        }

        private void ListBtn_Click(object sender, EventArgs e)
        {
            string name = NameBox.Text;
            string surname = SurnameBox.Text;
            string city = CityBox.Text;
            string duty = DutyBox.Text;
            string salary = SalaryBox.Text;

            int addedPersonnelID = DALPersonnel.AddPersonnel(name, surname, city, duty, salary);

            if (addedPersonnelID != -1)
            {
                MessageBox.Show($"Personnel added with ID: {addedPersonnelID}");
            }
            else
            {
                MessageBox.Show("Error occurred while adding personnel.");
            }

            // Yeniden listelemek için:
            List<EntityPersonnel> PerList = LogicPersonnel.LLPersonnelList();
            DataPanel.DataSource = PerList;
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDBox.Text);

            DALPersonnel.DelPersonnel(id);

            if (id >= 0)
            {
                MessageBox.Show($"Personel deleted with ID: {id}");
            }
            else
            {
                MessageBox.Show("Error occurred while deleting personnel.");
            }

            List<EntityPersonnel> PerList = LogicPersonnel.LLPersonnelList();
            DataPanel.DataSource = PerList;
        }
    }
}
