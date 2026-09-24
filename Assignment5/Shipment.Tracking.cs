using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal partial class StanddardShipment
    {
        private string trackingStatus = "shipment is Ready";

        
         public string GetTrackingStatusAgain()
         {
            return trackingStatus;
         }

        public void UpdateTrackingStatus(string newStatus) { 
           
              trackingStatus = newStatus;
        }
    }
}
