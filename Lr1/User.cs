using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr1
{
    internal class User
    {
        private string login;
        private string name;
        private string surname;
        private int age;
        private readonly string REGISTRATION_DATE;

        public User(String login, String name, String surname, int age, string REGISTRATION_DATE)
        {
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.REGISTRATION_DATE = REGISTRATION_DATE;
        }

        public void Print()
        {
            Console.WriteLine($"login:{login}, name:{name}, surname:{surname}, age:{age}, registration date:{REGISTRATION_DATE}");
        }

    }
}
