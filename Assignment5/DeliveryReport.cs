using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class DeliveryReport
    {
        public void PrintShipment(ITrackable shipment)
        {
            if (shipment != null)
            {
                Console.WriteLine(shipment.GetTrackingStatus());
            }

        }
        public void PrintInsurance(IInsurable shipment)
        {

            if (shipment != null)
            {
                Console.WriteLine(shipment.CalculateInsurance());
            }
        }
    }
}
