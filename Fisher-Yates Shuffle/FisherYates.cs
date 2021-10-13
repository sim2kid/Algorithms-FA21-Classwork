using System;
using System.Collections.Generic;
using System.Text;

namespace Fisher_Yates_Shuffle
{
    class FisherYates
    {
        string fileToRead = "data.csv";
        


        private static List<string> LoadCVS(string filelocation) 
        {
            List<string> output = new List<string>();
            string text = System.IO.File.ReadAllText(filelocation);
            string[] words = text.Split(",");
            foreach (string word in words) 
            {
                output.Add(word);
            }
            return output;
        }
    }
}
