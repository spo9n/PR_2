using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2_Surgai_ZVD3
{
    class Student
    {
        private string Name { get; set; }
        private string Surname { get; set; }
        private int[] Marks { get; set; }

        public Student() { }

        public void setName(string name) 
        { 
            this.Name = name; 
        }
        public void setSurname(string surname) 
        {
            this.Surname = surname; 
        }
        public void setMarks(int[] marks) 
        { 
            this.Marks = marks; 
        }
        public string getName() 
        { 
            return Name; 
        }
        public string getSurname() 
        {
            return Surname; 
        }
        public int[] getMarks() 
        { 
            return Marks; 
        }
    }
}