using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal  abstract partial class Shipment:ITrackable
    {
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryfee;
        private readonly string trackingCode1;
        private readonly string description1;
        private readonly double weight1;
        private readonly decimal deliveryFee;
        private readonly DeliveryAddress destination;
        
       


        public DeliveryAddress Destination { get; set; }

        public Shipment(string TrackingCode)
        {
            trackingCode = TrackingCode;
            description = "Un Known";
            weight = 1;
            deliveryfee = 50;
            Destination = default;
          

        }
        public Shipment(string TrackingCode, string Description, decimal Weight, decimal DeliveryFee, DeliveryAddress destination)
        {
            trackingCode1 = TrackingCode;
            description1 = Description;
            weight = Weight;
            deliveryFee = DeliveryFee;
            Destination = destination;
          
        }
        public string TrackingCode
        {
            get
            {
                if (!string.IsNullOrEmpty(trackingCode))
                {
                    return trackingCode;
                }
                return default;
            }
            private set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    trackingCode = value;
                }
            }

        }
        public string Description
        {
            get
            {
                if (!string.IsNullOrEmpty(description))
                {
                    return description;
                }
                return default;

            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    description = value;
                }
            }
        }
        public decimal Weight
        {
            get => weight;
            set
            {
                if (weight > 0)
                {
                    weight = value;
                }
            }
        }
        public decimal Deliveryfee
        {
            get => deliveryfee;
            private set
            {
                if (deliveryfee > 0)
                {
                    deliveryfee = value;
                }
            }
        }
        public abstract decimal EstimatedCost { get; }



        public abstract void PrintShipment();




        public void UpdateWeight(decimal newWeight)
        {
            if (newWeight > 0)
                weight = newWeight;
        }
        public void UpdateWeight(decimal baseWeight, decimal extraPackingWeight)
        {

            Weight = baseWeight + extraPackingWeight;
        }

        public string GetTrackingStatus()
        {
            return $"shipment sh003 is Ready";
        }
    }
}
