using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal partial class StandardShipment:Shipment,IInsurable,ITrackable
    {
        public static int TotalShipmentsCreated { get; set; }

        static StandardShipment()
        {
            TotalShipmentsCreated = 0;
            Console.WriteLine("static initialization has happened");
        }
        public  StandardShipment(string TrackingCode, string Description, decimal Weight, decimal DeliveryFee, DeliveryAddress destination) : base(TrackingCode, Description, Weight, DeliveryFee, destination)
        {
            TotalShipmentsCreated++;
        }
        
        public override decimal EstimatedCost => Deliveryfee + (Weight * 5m);

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.05m;
        }

        public string GetTrackingStatus()
        {
            return "Shipment SH001 is Ready.";
        }

        public override void PrintShipment()
        {
            Console.WriteLine($"TrackingCode : {TrackingCode},Description : {Description},Weight : {Weight},DeliveryFee : {Deliveryfee},Destination : {Destination}");
        }
        public StandardShipment ShallowCopy()
        {
            TotalShipmentsCreated++;
            return (StandardShipment)MemberwiseClone();
        }
        public StandardShipment DeepCopy()
        {
            TotalShipmentsCreated++;
            StandardShipment copy;
            copy = (StandardShipment)MemberwiseClone();
            copy.Destination =new DeliveryAddress(this.Destination.City,this.Destination.Street,this.Destination.BuildingNumber);
            return copy;
            
        }
        public static  int GetTotalShipmentsCreated()
        {
            return TotalShipmentsCreated;
        }
    }
}
