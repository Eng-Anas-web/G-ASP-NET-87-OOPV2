using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5.Class
{
    public struct Shipment
    {
        private string _trackingCode;
        private string _description;
        private double _weight;
        private decimal _deliveryFee;
        private DeliveryAddress _destination;



        public string TrackingCode
        {
            get
            {
                return _trackingCode;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _description = value;
                }
            }
        }

        public double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if (value > 0)
                {
                    _weight = value;
                }
            }
        }

        public decimal DeliveryFee
        {
            get
            {
                return _deliveryFee;
            }
            private set
            {
                if (value > 0)
                {
                    _deliveryFee = value;
                }
            }
        }
        public DeliveryAddress Destination
        {
            get
            {
                return _destination;
            }
            set
            {
                _destination = value;
            }
        }

        public decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + ((decimal)Weight * 5);
            }
        }

        public Shipment(string trackingCode)
        {
            _trackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress();
        }

        public Shipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
        {
            if (!string.IsNullOrWhiteSpace(trackingCode))
            {
                _trackingCode = trackingCode;
            }
                    Description = description;
                    Weight = weight;
                    DeliveryFee = deliveryFee;
                    Destination = destination;
                
            }
       
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
                {
                }
            }
        }


        public void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Delivery Fee: {DeliveryFee}");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}");
        }

    }
}