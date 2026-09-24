using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal static class DeliveryUtilities
    {
        public static void  PrintSeparator()
        {
            Console.WriteLine("-------------------------");
        }
        public static void PrintSystemTitle()
        {
            DeliveryCentre deliveryCentre = new DeliveryCentre("DeliveryCentre");
            Console.WriteLine(deliveryCentre.centreName);
        }
    }
}
