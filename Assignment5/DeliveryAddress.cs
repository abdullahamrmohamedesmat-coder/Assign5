using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class DeliveryAddress
    {
        public string City { get; set; }

        public string Street { get; set; }

        public int BuildingNumber { get; set; }

        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
        }

        public string GetAddress()
        {
            return $"{City},{Street},{BuildingNumber}";
        }

        public override string ToString()
        {
            return $"{City},{Street},{BuildingNumber}";
        }
    }
}
