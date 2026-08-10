using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5.Class
{
    public struct DeliveryCenter
    {
        private Shipment[] _shipment;

        public DeliveryCenter() {
            _shipment = new Shipment[10];
        }

        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < _shipment.Length)
                {
                    return _shipment[index];
                }

                return default;
            }

            set
            {
                if (index >= 0 && index < _shipment.Length)
                {
                    _shipment[index] = value;
                }
            }
        }

        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < _shipment.Length; i++)
                {
                    if (_shipment[i].TrackingCode == trackingCode)
                    {
                        return _shipment[i];
                    }
                }

                return default;
            }
        }



        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < _shipment.Length; i++)
            {
                if (_shipment[i].Equals(default(Shipment)))
                {
                    _shipment[i] = shipment;
                    return true;
                }
            }

            return false;
        }
    }
}