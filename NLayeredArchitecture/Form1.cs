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
            FList.ListFunc(DataPanel);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            EntityPersonnel p = new EntityPersonnel();

            string name = NameBox.Text;
            string surname = SurnameBox.Text;
            string city = CityBox.Text;
            string duty = DutyBox.Text;
            string salary = SalaryBox.Text;

            int addedPersonnelID = LogicPersonnel.LLAddPersonnel(p, name, surname, city, duty, salary);

            if (addedPersonnelID != -1)
            {
                MessageBox.Show($"Personnel added with ID: {addedPersonnelID}");
            }
            else
            {
                MessageBox.Show("Error occurred while adding personnel.");
            }

            // Yeniden listelemek için:
            FList.ListFunc(DataPanel);
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            EntityPersonnel p = new EntityPersonnel
            {
                ID = Convert.ToInt32(IDBox.Text)
            };

            LogicPersonnel.LLDelPersonnel(p);

            if (p.ID >= 0)
            {
                MessageBox.Show($"Personel deleted with ID: {p.ID}");
            }
            else
            {
                MessageBox.Show("Error occurred while deleting personnel.");
            }

            FList.ListFunc(DataPanel);
        }

        private void UpdBtn_Click(object sender, EventArgs e)
        {
            EntityPersonnel p = new EntityPersonnel();

            int id = Convert.ToInt32(IDBox.Text);
            string name = NameBox.Text;
            string surname = SurnameBox.Text;
            string city = CityBox.Text;
            string duty = DutyBox.Text;
            string salary = SalaryBox.Text;

            int updatedPersonnelID = LogicPersonnel.LLUpdatePersonnel(p, id, name, surname, city, duty, salary);

            if (updatedPersonnelID != -1)
            {
                MessageBox.Show($"Personnel updated with ID: {updatedPersonnelID}");
            }
            else
            {
                MessageBox.Show("Error occurred while updating personnel.");
            }

            FList.ListFunc(DataPanel);
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FList.ListFunc(DataPanel);
        }
    }
}
