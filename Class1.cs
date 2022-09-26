using System;
using System.Collections.Generic;
using System.Text;

namespace _1_exercise
{
    class Address
    {
        private int index;
        private string country;
        private string city;
        private string street;
        private int house;
        private int apartment;

        public int Index
        {
            get { return index; }
            set { index = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public int House
        {
            get { return house; }
            set { house = value; }
        }
        public int Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }

        public string GetAddress()
        {
            return $" Index: {index};\n Country: {country};\n City: {city};\n Street: {street};\n House: {house};\n Apartment: {apartment};";
        }

    }

    namespace _1_exercise
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Address solution\n");
                Address someAddress = new Address();

                someAddress.Index = 02138;
                someAddress.Country = "Ukraine";
                someAddress.City = "Kyiv";
                someAddress.Street = "Unnamed";
                someAddress.House = 8;
                someAddress.Apartment = 310;

                Console.WriteLine(someAddress.GetAddress());

                Console.ReadKey();
            }
        }
    }
}