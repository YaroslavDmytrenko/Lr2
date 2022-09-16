using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr1
{
    internal class Employee
    {
        private String name;
        private String surname;
        private Enum position;
        private int salary;
        private int experience;
        private float tax = 0.05F;


        public Employee(string name, string surname, Enum position)
        {
            this.name = name;
            this.surname = surname;
            this.position = position;
        }

        public void CfgSalary()
        {
            switch (position)
            {
                case Positions.Junior:
                    salary = 800;
                    salary += salary * (experience / 100);
                    CfgTax();
                    break;
                case Positions.Midle:
                    salary = 1200;
                    salary += salary * (experience / 100);
                    CfgTax();
                    break;
                case Positions.Senior:
                    salary = 1600;
                    salary += salary * (experience / 100);
                    CfgTax();
                    break;
                case Positions.TeamLead:
                    salary = 2000;
                    salary += salary * (experience / 100);
                    CfgTax();
                    break;
                default:
                    salary = 0;
                    CfgTax();
                    break;
            }
        }

        public void CfgExperience()
        {
            Random random = new Random();
            experience = (1 * random.Next() % 20);
        }

        public void CfgTax()
        {
            salary = (int)(salary - (salary * tax));
        }

        public void Auto()
        {
            CfgExperience();
            CfgSalary();
            CfgTax();
            Print();
        }
        public void Print()
        {
            Console.WriteLine($"name:{name}, surname:{surname}, position:{position}, salary:{salary}, experience:{experience}, tax:{tax}");
        }

        public enum Positions
        {
            Junior,
            Midle,
            Senior,
            TeamLead
        }

       
    }
}
