using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr1
{
    internal class Address
    {
        private int index;
        private string country;
        private string city;
        private string street;
        private int house;
        private int apartment;

        public Address(int index, string country, string city, string street, int house, int apartment)
        {
            this.index = index;
            this.country = country;
            this.city = city;
            this.street = street;
            this.house = house;
            this.apartment = apartment;
        }

        public void ToString()
        {
            Console.WriteLine($"index:{index}, country:{country}, city:{city}, street:{street}, house:{house}, apartment:{apartment}");
        }

        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                if (value > 0)
                {
                    index = value;
                }
            }
        }

        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }

        public string Street
        {
            get
            {
                return street;
            }
            set
            {   
                street = value;
            }
        }

        public int House
        {
            get
            {
                return house;
            }
            set
            {
                if (value > 0)
                {
                    house = value;
                }
            }
        }

        public int Apartment
        {
            get
            {
                return apartment;
            }
            set
            {
                if (value > 0)
                {
                    apartment = value;
                }
            }
        }

    }
}
