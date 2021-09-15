using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Algorithms_FA21_Classwork
{
    static class BigOExample2_9
    {
        public static string About()
        {
            int[] list = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();
            var constantO = ConstantO(5);
            stopWatch.Stop();

            var constTime = stopWatch.Elapsed.TotalSeconds;
            stopWatch.Reset();

            stopWatch.Start();
            var linearO = LinearO(list);
            stopWatch.Stop();

            var linTime = stopWatch.Elapsed.TotalMilliseconds;
            stopWatch.Reset();

            stopWatch.Start();
            var quadO = QuadraticO(list);
            stopWatch.Stop();

            var quadTime = stopWatch.Elapsed.TotalMilliseconds;
            stopWatch.Reset();

            return $"This is the Week 2 BigO Example Demo Project.\nIn here we will show off the few types of scaling with BigO.\n" +
                $"\nTo start, we have Constant O or O(1). This function will add n to itself. Let's put in a '5' for this function:\n" +
                $"ConstantO(n)\n{{\n" +
                $"    return n + n\n" +
                $"}}\n" +
                $"And the output we get is: `{constantO}` and it took {constTime} milliseconds.\n" +
                $"\nNext, we have a Linear O or O(n) function.\nThe number of items for n will directly corrlate to the time it takes to compute this function.\n" +
                $"We will put in a short list for this function: [1, 2, 3, 4, 5, 6, 7, 8, 9]\n" +
                $"LinearO(n)\n{{\n" +
                $"    var temp = 0;\n" +
                $"    foreach (item in n)\n    {{\n" +
                $"        temp += item;\n" +
                $"    }}\n" +
                $"    return temp;\n" +
                $"}}\n" +
                $"And our output is `{linearO}` and it took {linTime} milliseconds.\n" +
                $"\nLastly, we have Quadratic O or O(n²).\nThe number of items for n will be quadratically higher for the time it takes to commute this function.\n" +
                $"This function is essentially 2 nested linear O functions from before.\n" +
                $"We'll use the same list as before in out function.\n" +
                $"QuadraticO(n)\n{{\n" +
                $"    var temp = 0;\n" +
                $"    foreach (item in n)\n    {{\n" +
                $"        temp += LinearO(n) * item;\n" +
                $"    }}\n" +
                $"    return temp;\n" +
                $"}}\n" +
                $"And out output is `{quadO}` and it took {quadTime} milliseconds.\n" +
                $"Note: This function may be faster due to CPU acceleration and compiling magic since LinearO(n) has been calculated before.";
        }
        /// <summary>
        /// This function will always run for the same amount of time no matter what value is put in for <paramref name="n"/>. 
        /// This gives it a BigO of O(1)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int ConstantO(int n) 
        {
            return n + n;
        }

        /// <summary>
        /// This function scales linearly. The number of items for <paramref name="n"/> will directly corrlate to the time it takes to compute this function.
        /// This gives it a BigO of O(<paramref name="n"/>)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int LinearO(int[] n) 
        {
            int toReturn = 0;
            foreach (int num in n) 
            {
                toReturn += num;
            }
            return toReturn;
        }

        /// <summary>
        /// This function scales Quadratically. The number of items for <paramref name="n"/> will be squared in corrlation to the time it takes to compute this function.
        /// This is essentially <see cref="LinearO(List{int})"/> nested inside of a <see cref="LinearO(List{int})"/>.
        /// This gives it a BigO of O(<paramref name="n"/>²)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int QuadraticO(int[] n) 
        {
            int toReturn = 0;
            foreach (int num in n) 
            {
                toReturn += num * LinearO(n);
            }
            return toReturn;
        }
    }
}
