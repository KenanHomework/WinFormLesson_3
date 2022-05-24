using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormLesson_3.Anket_2
{
    public class User
    {
        public User(string name, string surname, string email, string phone, DateTime birthDate)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Phone = phone;
            BirthDate = birthDate;
        }

        public string Name { get; set; }
        public string Surname { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public DateTime BirthDate { get; set; }

        public override string ToString() => $"{Name} ~ {Surname}";

        public void Change(User user)
        {
            Name = user.Name;
            Surname = user.Surname;
            Email = user.Email;
            Phone = user.Phone;
            BirthDate = user.BirthDate;
        }

    }
}
