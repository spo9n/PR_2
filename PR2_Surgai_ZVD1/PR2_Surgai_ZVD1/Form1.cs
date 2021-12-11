using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR2_Surgai_ZVD1
{
    public partial class Form1 : Form
    {
        List<string> surnameList;

        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            surnameList = new List<string>();

            foreach (string str in richTextBox1.Lines)
            {
                surnameList.Add(str);
            }

            MessageBox.Show("Прізвища було додано у масив рядків.", "Успіх!");
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            surnameList.Sort();

            richTextBox1.Text = "";

            foreach(string str in surnameList)
            {
                richTextBox1.Text += str + "\n";
            }
        }

        private void longestSurnameButton_Click(object sender, EventArgs e)
        {
            string longestSurname = surnameList[0];

            for (int i = 0; i < surnameList.Count(); i++)
            {
                if (surnameList[i].Length > longestSurname.Length)
                {
                    longestSurname = surnameList[i];
                }
            }

            MessageBox.Show("Найдовше прізвище - " + longestSurname.ToString(), "Пошук найдовшого прізвища...");
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsLetter(e.KeyChar)) return;
            e.Handled = true;
        }
    }
}
