using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR2_Surgai_ZVD3
{
    public partial class MainForm : Form
    {
        List<Student> students = new List<Student>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (surnameTextBox.Text.Length == 0 || nameTextBox.Text.Length == 0 || marksTextBox.Text.Length == 0)
            {
                MessageBox.Show("Необхідно заповнити усі поля!");
            }
            else
            {
                Student student = new Student();

                student.setSurname(surnameTextBox.Text);
                student.setName(nameTextBox.Text);
                student.setMarks(Array.ConvertAll(marksTextBox.Text.Split(';'), int.Parse));

                students.Add(student);

                surnameTextBox.Clear();
                nameTextBox.Clear();
                marksTextBox.Clear();

                MessageBox.Show("Запис створено!");
            }
        }

        private void grantButton_Click(object sender, EventArgs e)
        {
            StaticData.Value = students;
            GrantForm form = new GrantForm();
            form.Show();
        }
    }
}