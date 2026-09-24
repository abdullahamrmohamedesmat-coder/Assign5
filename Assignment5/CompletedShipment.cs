using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class CompletedShipment:Shipment
    {
        public CompletedShipment(string TrackingCode, string Description, decimal Weight, decimal DeliveryFee, DeliveryAddress destination) : base(TrackingCode, Description, Weight, DeliveryFee, destination)
        {
        }

        public override decimal EstimatedCost => Deliveryfee + (Weight * 5m);

        public override void PrintShipment()
        {
            Console.WriteLine(TrackingCode, Description, Weight, Deliveryfee, Destination);
        }
    }
}
