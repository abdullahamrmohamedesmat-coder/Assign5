using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Driver
    {
        private int driverdId;
        private string fullName;
        private string phoneNumber;

        public Driver(int DriverdId, string FullName, string PhoneNumber)
        {
            this.driverdId = driverdId;
            fullName = FullName;
            PhoneNumber = phoneNumber;
            driverdId = DriverId;
            FullName = fullName;
            PhoneNumber = phoneNumber;
        }

        public int DriverId
        {
            get { return driverdId; }

            set
            {
                if (value > 0)
                {
                    driverdId = value;
                }
            }
        }
        public string FullName
        {
            get { return fullName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    fullName = value;
                }
            }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    phoneNumber = value;
                }

            }
        }
        public void PrintDriverInfo()
        {
            Console.WriteLine($"Driver Id : {DriverId}");
            Console.WriteLine($"Full Name : {FullName}");
            Console.WriteLine($"Phone Number : {PhoneNumber}");
        }
    }
}
