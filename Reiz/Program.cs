using System;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateAngle(6, 5));
        }
        /// <summary>
        /// Calculates lesser angle between hours and minutes hands in analog clock
        /// </summary>
        /// <param name="hours">Input hours</param>
        /// <param name="minutes">Input minutes</param>
        /// <returns>Angle in float</returns>
        private static float CalculateAngle(int hours,int minutes)
        {
            float angle = 0;
            if(hours > 12 || hours < 0)
            {
                Console.WriteLine("Bad hours input");
                return -1;
            }
            if (minutes > 59 || minutes < 0)
            {
                Console.WriteLine("Bad minutes input");
                return -1;
            }
            // 360 degrees divided into 12 is 30 per hour and 1 minute move hand by 0.5 degree
            float hoursAngle = hours * 30 + minutes * 0.5f;

            // 360 degrees divided into 60 mins is 6 per minute
            float minutesAngle = minutes * 6; 

            angle = Math.Abs(hoursAngle - minutesAngle);

            if(angle > 180)
            {
                angle = 360 - angle;
            }

            return angle;
        }
    }
}
