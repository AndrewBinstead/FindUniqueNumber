using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    using System.Diagnostics;

    class Program
    {
        private static void Main(string[] args)
        {
            int result = runTest();
        }


        protected static int runTest()
        {
            int[] A = { 1, 4, 3, 3, 1, 2 };

            // Validation
            // Make sure the array is not null
            if(A == null)
            {
                return -1;
            }
        
            // Make sure the array is not empty
            if(A.Length == 0 && A.Length <= 100000)
            {
                return -1;
            }
        
            // Validate items in array
            foreach(int item in A)
            {
                if(item <= 0 || item > 1000000000)
                {
                    return -1;
                }
            }

            var uniqueChecker = new Uniqueness();
            int answer = uniqueChecker.findUniqueItem(A);
            return answer;
        }


        

    }
}
