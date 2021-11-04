using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    public static class Examples
    {
        public static string[] GenerateRandomArray(int length)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < length; i++)
                list.Add(RandomLetters());
            return list.ToArray();
        }

        public static string[] GenerateOrderedArray(int length) 
        {
            List<string> list = new List<string>();
            for (int i = 1; i < length+1; i++)
                list.Add(i.ToString());
            return list.ToArray();
        }

        public static Dictionary<string, string> GetDictionary(string[] key, string[] value) {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            
            for(int i = 0; i < key.Length && i < value.Length; i++) 
            {
                dict.Add(key[i], value[i]);
            }

            return dict;
        }

        public static Stack<string> GetStack(string[] array) 
        {
            Stack<string> stack = new Stack<string>();
            foreach (var item in array) 
            {
                stack.Push(item);
            }
            return stack;
        }

        public static Queue<string> GetQueue(string[] array) 
        {
            Queue<string> queue = new Queue<string>();
            foreach (var item in array) 
            {
                queue.Enqueue(item);
            }
            return queue;
        }

        public static string RandomLetters() 
        {
            Random r = new Random();
            string s = string.Empty;

            for (int i = r.Next(10, 25); i > 0; i--) {
                if (r.Next(0, 100) % 2 == 0)
                {
                    s += (char)r.Next(65, 91);
                }
                else
                {
                    s += (char)r.Next(97, 123);
                }
            }
            return s;
        }
    }
}
