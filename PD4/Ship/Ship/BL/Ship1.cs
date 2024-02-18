using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship.BL
{
    internal class Ship1
    {
        public string ShipNumber;
        public Angle Latitude;
        public Angle Longitude;
        
        public Ship1 (string shipNumber, Angle latitude, Angle longitude)
        {
            this.ShipNumber = shipNumber;
            this.Latitude = latitude;
            this.Longitude = longitude;
        }
    }
}
