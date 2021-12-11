using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2_Surgai_ZVD4
{
    class Resident
    {
        private string Surname;

        private string Name;

        private string Patronymic;

        private string Address;

        private DateTime DateOfBirth;

        public Resident() { }

        public Resident(string surname, string name, string patronymic, string address, DateTime dateOfBirth)
        {
            this.Name = name;
            this.Surname = surname;
            this.Patronymic = patronymic;
            this.Address = address;
            this.DateOfBirth = dateOfBirth;
        }

        public void setSurname(string surname) 
        { 
            this.Surname = surname; 
        }

        public void setName(string name) 
        { 
            this.Name = name; 
        }

        public void setPatronymic(string patronymic) 
        { 
            this.Patronymic = patronymic; 
        }
        public void setDateOfBirth(DateTime dateOfBirth) 
        { 
            this.DateOfBirth = dateOfBirth; 
        }

        public string getSurname()
        {
            return Surname;
        }

        public string getName()
        { 
            return Name; 
        }

        public string getPatronymic() 
        { 
            return Patronymic;
        }

        public DateTime getDateOfBirth() 
        { 
            return DateOfBirth; 
        }
    }
}