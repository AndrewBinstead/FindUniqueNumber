using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Uniqueness
    {
        // Go through all the items in the array from the start, find the 
        // first unique number in the array
        public int findUniqueItem(int[] A)
        {
            // Hold a list of numbers that have already been seen
            List<int> foundNumbers = new List<int>();

            // Loop through all the items of the array
            for (int i = 0; i < A.Length; i++)
            {
                // Get the current item
                int current = A[i];
                bool isUnique = true;

                // Check if it has already been seen
                if (!foundNumbers.Contains(current))
                {
                    // Loop through all the remaining items
                    for (int search = i + 1; search < A.Length; search++)
                    {
                        // Is there a match
                        if (A[search] == current)
                        {
                            // Match found
                            isUnique = false;
                            // Add the number of the ones already seen
                            foundNumbers.Add(A[search]);
                            break;
                        }
                    }
                }
                else
                {
                    // Seen before
                    isUnique = false;
                }

                // No matches, unique number found
                if (isUnique)
                {
                    return current;
                }
            }

            // No unique numbers
            return -1;
        }
    }
}
