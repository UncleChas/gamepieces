using System;
using System.Collections.Generic;
using System.Text;

namespace GamePieces
{
    public static class Extensions
    {
        /**
         * So Python has a nice gaussian function in it's random number generator, but we don't have that unless I reimplement it
         * instead, I'm going to generate N random numbers in the valid range then average them. Results should be a bell curve 
         * centered on the middle of the range
         */
        public static double CurvedNextDouble(this Random rand, int itterations)
        {
            double result;
            double runningTotal = 0;
            for (int count = 0; count < itterations; count++)
            {
                runningTotal += rand.NextDouble();
            }
            if (runningTotal > 0)
            {
                result = runningTotal / itterations;
            }
            else
            {
                result = 0;
            }
            return result;
        }
    }
}
