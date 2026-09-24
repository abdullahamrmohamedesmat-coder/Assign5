using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class InternationalShipment:Shipment,ITrackable,IInsurable
    {
        private string destinationCountry;
        private decimal customFee;
        public InternationalShipment(string TrackingCode, string Description, decimal Weight, decimal DeliveryFee, DeliveryAddress destination, string DestinationCountry, decimal CustomFee) : base(TrackingCode, Description, Weight, DeliveryFee, destination)
        {
            destinationCountry = DestinationCountry;
            customFee = CustomFee;
        }

        public string DestinationCountry
        {
            get
            {
                if (!string.IsNullOrEmpty(DestinationCountry))
                {
                    return destinationCountry;
                }
                return destinationCountry;

            }
            set
            {
                if (!string.IsNullOrEmpty(DestinationCountry))
                {

                    destinationCountry = value;


                }
            }
        }
        public decimal CustomFee
        {
            get => CustomFee;
            set
            {
                if (CustomFee > 0)
                {

                    CustomFee = value;
                }
            }
        }
        public override decimal EstimatedCost
        {
            get
            {
                return Deliveryfee + ((decimal)Weight * 5m) + CustomFee;
            }
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.12m;
        }

        public virtual void GenerateCustomReport()
        {
            Console.WriteLine($"Custom Report Generated for {TrackingCode}");
        }

        public string GetTrackingStatus() => " SH003 has been Delivered.";





        public override void PrintShipment()
        {
            Console.WriteLine($"TrackingCode : {TrackingCode},Description : {Description},Weight : {Weight},DeliveryFee : {Deliveryfee},Destination : {Destination},DestinationCountry : {DestinationCountry},CustomFee :{CustomFee} ");
        }
    }
}
