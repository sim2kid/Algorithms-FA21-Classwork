using System;

namespace Data_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 100000;
            string[] values = Examples.GenerateRandomArray(size);
            string[] orderedList = Examples.GenerateOrderedArray(size);
            Dictionary<string, string> dict = Examples.GetDictionary(orderedList, values);
            Stack<string> stack = Examples.GetStack(orderedList);
            Queue<string> queue = Examples.GetQueue(orderedList);

            Console.WriteLine($"In programming, there are many different ways to store data. " +
                $"In this program, we explore a few of those data structures and evaluate when to use them and when not to use them.\n\n" +
                $"Strating off, we have Arrays and Maps. An array is just a list of like values. They're usually indexed by their position in an array.\n" +
                $"Here's an example array with 5 values in it.\n{PrintArray(orderedList, 5)}" +
                $"In the case of an Array, all the values are directly mapped to their position.\n" +
                $"This is the generic way to store a bunch of values.\n\n" +
                $"In a Map/Dictionaty/Hash Table, these objects are instead mapped to another string/object. " +
                $"This improves preformance of finding and inserting objects by abstracting their location into hashes.\n" +
                $"Here's an example of the previous array mapping to random values of letters.\n{PrintDictionary(dict, 5)}\n" +
                $"Dictionaries are best when you don't need an ordered list or if you're storing a lot of data that you're not going to loop through very often.\n" +
                $"In other words, it's best if you're going to pick a value based off of the key.\n\n" +
                $"We can use those ways of storing data and wrap them in ways to access data.\n" +
                $"Two of those ways are Stacks and Queues.\n\n" +
                $"A Stack is a First In Last Out data structure.\n" +
                $"It's like putting sheets of paper on top of eachother. You can't access the lower papers without removing the one on top.\n" +
                $"Let's take a stack of {size} values and add all of those as numbers in order.\n" +
                $"The current top number is \"{stack.Peek()}\" which is the last number we added.\n" +
                $"If we take of 10 from the stack, the new top number should be {popNumber(stack, 10)}.\n" +
                $"If we take a look after doing so, the number is the same, \"{stack.Peek()}\"\n\n" +
                $"Now looking at Queue, the Queue is a First in First out system.\n" +
                $"Let's make our Queue with the same array as the stack.\n" +
                $"Our current begining of the Queue is \"{queue.Peek()}\" which is the first number in our queue.\n" +
                $"If we dequeue {processQueue(queue, 22)} objects, then our next position in the queue is \"{queue.Peek()}\"\n\n");
        }

        public static string PrintArray(object[] array, int length = int.MaxValue) 
        {
            string s = string.Empty;
            for(int i = 0; i < array.Length && i < length; i++)
            {
                s += $"[{i}]: \"{array[i].ToString()}\"\n";
            }
            return s;
        }

        public static string PrintDictionary<T1,T2>(Dictionary<T1,T2> dictionary, int length = int.MaxValue)
        {
            string s = string.Empty;
            int i = 0;
            foreach (KeyValuePair<T1, T2> kvp in dictionary) 
            {
                if (i >= length)
                    break;
                s += $"\"{kvp.Key.ToString()}\" : \"{kvp.Value.ToString()}\"\n";
                i++;
            }
            return s;
        }

        public static string popNumber<T>(Stack<T> stack, int amount) 
        {
            for (int i = 0; i < amount; i++)
                stack.Pop();
            return stack.Count.ToString();
        }

        public static string processQueue<T>(Queue<T> queue, int amount) 
        {
            for (int i = 0; i < amount; i++)
                queue.Dequeue();
            return amount.ToString();
        }
    }
}
