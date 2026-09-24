using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class ExpressShipment:Shipment
    {
        private decimal extraFee;
        public ExpressShipment(string TrackingCode, string Description, decimal Weight, decimal DeliveryFee, DeliveryAddress destination, decimal ExtraFee) : base(TrackingCode, Description, Weight, DeliveryFee, destination)
        {
            extraFee = ExtraFee;

        }
        public decimal ExtraFee
        {
            get => extraFee;
            set
            {
                if (value <= 0)
                {
                    extraFee = value;
                }
            }
        }
        public override decimal EstimatedCost
        {
            get
            {

                return Deliveryfee + ((decimal)Weight * 5m) + ExtraFee;
            }
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m;
        }

        public string GetTrackingStatus()
        {

            return "Shipment SH002 is Out for Delivery.";

        }





        public override void PrintShipment()
        {
            Console.WriteLine($"TrackingCode : {TrackingCode},Description : {Description},Weight : {Weight},DeliveryFee : {Deliveryfee},Destination : {Destination},ExtraFee : {ExtraFee}");
        }
    }
}
