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
    public partial class GrantForm : Form
    {
        List<Student> students = StaticData.Value;

        public GrantForm()
        {
            InitializeComponent();
        }

        private void GrantForm_Load(object sender, EventArgs e)
        {
            foreach (Student student in students)
            {
                bool flag = true;

                foreach (int mark in student.getMarks())
                {
                    if (mark < 4)
                    {
                        flag = false;
                    }
                }

                if (flag)
                {
                    grantDataGridView.Rows.Add(student.getSurname(), student.getName(), string.Join(" ", student.getMarks()));
                }
            }
        }
    }
}