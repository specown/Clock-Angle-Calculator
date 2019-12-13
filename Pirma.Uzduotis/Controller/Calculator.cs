using Pirma.Uzduotis.Interface;
using System;

namespace Pirma.Uzduotis.Controller
{
    public class Calculator : ICalculator
    {
        public int CalculateAngle(int hours, int minutes)
        {
            //Calculate hour angle according to 12 hour hand
            int hourAngle = (int)(0.5 * (hours * 60 + minutes));

            //Calculate minute angle according to 12 hour hand 
            int minuteAngle = (int)(6 * minutes);

            //Calculate the difference between two angles
            int angleDifference = Math.Abs(hourAngle - minuteAngle);

            //As task requested, return the smaller angle
            return Math.Min(360 - angleDifference, angleDifference);
        }
    }
}
