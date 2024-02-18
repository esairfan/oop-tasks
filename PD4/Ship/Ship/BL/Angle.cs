using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship.BL
{
    internal class Angle
    {
        public int Degrees;
        public float Minutes;
        public char Direction;

        public Angle(int degrees, float minutes, char direction)
        {
            Degrees = degrees;
            Minutes = minutes;
            Direction = direction;
        }
        public string AngleS()
        {
            string answer;
            answer = Degrees.ToString() + "\u00b0" + Minutes.ToString() + "'" + Direction;
            return answer;
        }
    }
}
