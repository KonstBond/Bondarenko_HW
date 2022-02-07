using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Address
    {
        private string index, country, city, street, house, apartment;

        public Address(string index, string street, string house)
        {
            this.Index = index;
            this.Street = street;
            this.House = house;
        }

        public Address(string index, string street, string house, string apartment) : this(index, street, house)
        {
            this.Apartment = apartment;
        }

        public string Index 
        { 
            get 
            { 
                return index; 
            }
            set 
            {
                index = value;
                int tempCheker;
                int garbage;
                if (index.Length == 5 && int.TryParse(index, out tempCheker))
                {   
                    Country = "Ukraine";
                    switch (tempCheker)
                    {
                        case int temp when (temp >= 49000 && temp <= 49489):
                            city = "Dnieper";
                            break;
                        case int temp when (temp >= 01001 && temp <= 04655):
                            city = "Kiev";
                            break;
                        case int temp when (temp >= 65000 && temp <= 65485):
                            city = "Odessa";
                            break;
                        default:
                            city = "Unknown";
                            break;
                    }
                }
                else if (index[0] == 'A' && int.TryParse(index[1].ToString(), out garbage) && index.Length <= 5 && int.TryParse(index[1..], out tempCheker))
                {
                    Country = "Argentina";
                    switch (tempCheker)
                    {
                        case int temp when (temp == 4400):
                            city = "Salta";
                            break;
                        case int temp when (temp == 5000):
                            city = "Cordoba";
                            break;
                        case int temp when (temp == 5500):
                            city = "Mendoza";
                            break;
                        default:
                            city = "Unknown";
                            break;
                    }
                }
                else if (!int.TryParse(index[0].ToString(), out garbage) && !int.TryParse(index[1].ToString(), out garbage) && index.Length <= 5 && int.TryParse(index[2..], out tempCheker))
                {
                    Country = "United Kingdom";
                    switch (tempCheker)
                    {
                        case int temp when (index[0..2] == "AB" && (temp >= 10 && temp <= 13)):
                            city = "Aberdeen";
                            break;
                        case int temp when (index[0..2] == "BN" && (temp == 1 || temp == 2)):
                            city = "Brighton";
                            break;
                        case int temp when (index[0..2] == "PL" && (temp >= 1 && temp <= 9)):
                            city = "Plymouth";
                            break;
                        default:
                            city = "Unknown";
                            break;
                    }
                }
               
                else
                {
                    Country = City = "Unknown";
                }
            } 
        }

        public string Country { get{return country; } private set {country = value; } }
        public string City { get { return city; } private set { city = value; } }
        public string Street { get { return street; } set { street = value; } }

        public string House { get { return house; } set { house = value; } }
        public string Apartment { get { return apartment; } private set { apartment = house != default ? value: null; } }

        public void GetAddress() 
        {
            if (Apartment == null)
            {
                Console.WriteLine($"Index: {Index}\n" +
                                $"Country: {Country}\n" +
                                $"City: {City}\n" +
                                $"Street: {Street}\n" +
                                $"House: {House}");
            }
            else
            {
                Console.WriteLine($"Index: {Index}\n" +
                                $"Country: {Country}\n" +
                                $"City: {City}\n" +
                                $"Street: {Street}\n" +
                                $"House: {House}\n" +
                                $"Apartment: {Apartment}");
            }
            
        }
    }
}
