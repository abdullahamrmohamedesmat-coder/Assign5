using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class PriortyInternationalShipment:InternationalShipment
    {
        public PriortyInternationalShipment(string TrackingCode, string Description, decimal Weight, decimal DeliveryFee, DeliveryAddress destination, string DestinationCountry, decimal CustomFee) : base(TrackingCode, Description, Weight, DeliveryFee, destination, DestinationCountry, CustomFee)
        {
        }

        public sealed override void GenerateCustomReport()
        {
            Console.WriteLine($"priorty Custom Report Generated for {TrackingCode} ");
        }
    }
}
