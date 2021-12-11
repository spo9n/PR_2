using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR2_Surgai_ZVD4
{
    public partial class MainForm : Form
    {
        List<Resident> residents = new List<Resident>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (surnameTextBox.Text.Length == 0 || nameTextBox.Text.Length == 0 || patronymicTextBox.Text.Length == 0 || addressTextBox.Text.Length == 0 || dateOfBirthDateTimePicker.Value >= DateTime.Now)
            {
                MessageBox.Show("Необхідно заповнити усі поля!");
            }
            else
            {
                Resident resident = new Resident(surnameTextBox.Text, nameTextBox.Text, patronymicTextBox.Text, addressTextBox.Text, dateOfBirthDateTimePicker.Value);
                residents.Add(resident);


                dataGridView.Rows.Add(surnameTextBox.Text, nameTextBox.Text, patronymicTextBox.Text, addressTextBox.Text, dateOfBirthDateTimePicker.Value.ToShortDateString());
                
                surnameTextBox.Clear();
                nameTextBox.Clear();
                patronymicTextBox.Clear();
                addressTextBox.Clear();
                dateOfBirthDateTimePicker.Value = DateTime.Now;

                MessageBox.Show("Запис створено!");
            }
        }

        private void createListButton_Click(object sender, EventArgs e)
        {
            if (searchAddressTextBox.Text.Length == 0)
            {
                MessageBox.Show("Необхідно ввести адресу для пошуку!");
            }
            else
            {
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    if (dataGridView.Rows[i].Cells[3].Value.ToString() != searchAddressTextBox.Text &&
                        DateTime.Parse(dataGridView.Rows[i].Cells[4].Value.ToString()).Year >= 18)
                    {
                        dataGridView.Rows.RemoveAt(i);
                        dataGridView.Refresh();
                    }
                }

                MessageBox.Show("Створено список виборців за адресою: " + searchAddressTextBox.Text);

                searchAddressTextBox.Clear();
            }
        }
    }
}