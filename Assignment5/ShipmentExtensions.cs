using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            return $"{shipment.TrackingCode},{shipment.GetType},{shipment.Weight},{shipment.GetTrackingStatus}";
        }
        public static bool IsDelivered(this Shipment shipment)
        {
            if (shipment.GetTrackingStatus() == "Deliverd")
            {
                return true ;
            }
            return false;
        }

    }
}