using System;
using System.Collections.Generic;
using System.Text;

namespace Fisher_Yates_Shuffle
{
    public static class FisherYates
    {
        // This is our random number generator (Psudo-Random)
        private static Random randomNumber = new Random();

        public static object[] FisherYatesShuffle(this object[] objects) 
        {
            // We loop through the array starting from the end and going down
            for (int i = objects.Length - 1; i > 0; i--) 
            {
                // We swap out current object with one at random betweem the begining of the array and the current object (so it might not get swapped)
                Swap(objects, i, GetRandomNumber(i + 1));
                // We only swap a number once so once it's randomized, it isn't touched again.
                // That gives this specific Algorithm an O(N) at Max and Min cases.
            }
            return objects;
        }

        public static object[] AltFisherYatesShuffle(this object[] objects)
        {
            // This is the same algorithm just going from the start to the end of the array
            for (int i = 0; i < objects.Length-2; i++)
            {
                // The specifications set j between 0 ≤ j < n-i and have the 2nd position a[i+j]
                // If you look at the maths, that mean if the 2nd pos is a[j], then j = rand(max - i) + i
                // and that is the equivlent to the Min, Max random math, so i just added that
                Swap(objects, i, GetRandomNumber(i, objects.Length));
            }
            return objects;
        }

        private static void Swap(this object[] objects, int i, int j) 
        {
            // This just swaps two object's places in an array
            object temp = objects[i];
            objects[i] = objects[j];
            objects[j] = temp;
        }

        /// <summary>
        /// Return a random number between [<paramref name="min"/>, <paramref name="max"/>)
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        private static int GetRandomNumber(int min, int max) 
        {
            // This returns the next random number between [min,max) where max is exclusive and min is inclusive.
            
            return randomNumber.Next(max - min) + min;
        }
        private static int GetRandomNumber(int max)
        {
            // an overflow where min = 0
            // Also the guy in the video added 1 to the max like a dumb dumb... so I didn't do that.
            return GetRandomNumber(0, max);
        }
    }
}
