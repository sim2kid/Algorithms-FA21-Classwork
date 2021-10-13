using System;
using System.Collections.Generic;

namespace Fisher_Yates_Shuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Words = LoadCVS("data.csv");
            Console.WriteLine($"Before Shuffle:\n{WriteList(Words)}");
            Words = ArrayToList<string>(FisherYates.AltFisherYatesShuffle(Words.ToArray()));
            Console.WriteLine($"\nAfter Shuffle:\n{WriteList(Words)}");
        }

        private static List<T> ArrayToList<T>(object[] array) 
        {
            List<T> list = new List<T>();
            foreach (object o in array)
                list.Add((T)o);
            return list;
        }

        private static string WriteList(List<string> strs) 
        {
            string back = string.Empty;
            foreach (string s in strs)
                back += $"{s} ";
            return back;
        }

        private static List<string> LoadCVS(string filelocation)
        {
            string text = System.IO.File.ReadAllText(filelocation);
            return ArrayToList<string>(text.Split(","));
        }
    }
}
