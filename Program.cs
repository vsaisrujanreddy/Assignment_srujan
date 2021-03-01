using System;
using System.Linq;
using System.Collections.Generic;

namespace Assignment2_DIS_Spring2021
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Question 1
            Console.WriteLine("Question 1");
            int[] ar1 = { 2, 5, 1, 3, 4, 7 };
            int n1 = 3;
            ShuffleArray(ar1, n1);

            //Question 2 
            Console.WriteLine("Question 2");
            int[] ar2 = { 0, 1, 0, 3, 12 };
            MoveZeroes(ar2);
            Console.WriteLine("");

            //Question3
            Console.WriteLine("Question 3");
            int[] ar3 = { 1, 2, 3, 1, 1, 3 };
            CoolPairs(ar3);
            Console.WriteLine();

            //Question 4
            Console.WriteLine("Question 4");
            int[] ar4 = { 2, 7, 11, 15 };
            int target = 9;
            TwoSum(ar4, target);

            //Question 5
            Console.WriteLine("Question 5");
            string s5 = "korfsucy";
            int[] indices = { 6, 4, 3, 2, 1, 0, 5, 7 };
            RestoreString(s5, indices);
            Console.WriteLine();

            //Question 6
            Console.WriteLine("Question 6");
            string s61 = "bulls";
            string s62 = "sunny";
            if (Isomorphic(s61, s62))
            {
                Console.WriteLine("Yes the two strings are Isomorphic");
            }
            else
            {
                Console.WriteLine("No, the given strings are not Isomorphic");
            }
            Console.WriteLine();

            //Question 7
            Console.WriteLine("Question 7");
            int[,] scores = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
            HighFive(scores);
            Console.WriteLine();

            //Question 8
            Console.WriteLine("Question 8");
            int n8 = 19;
            if (HappyNumber(n8))                                                                       // Prints the statement according to the value returned from the HappyNumber() funtion written below
            {
                Console.WriteLine("{0} is a happy number", n8);
            }
            else
            {
                Console.WriteLine("{0} is not a happy number", n8);
            }
            Console.WriteLine();
           
            //Question 9
            Console.WriteLine("Question 9");
            int[] ar9 = { 7, 1, 5, 3, 6, 4 };
            int profit = Stocks(ar9);
            if (profit == 0)                                                                            // Printing the output according to the value of profit obtained from the Stocks() function written below
            {
                Console.WriteLine("No Profit is possible");
            }
            else
            {
                Console.WriteLine("Profit is {0}", profit);
            }

            Console.WriteLine();

            //Question 10
            Console.WriteLine("Question 10");
            int n10 = 3;
            Stairs(n10);
            Console.WriteLine();

        }

        //Question 1
        /// <summary>
        /// Shuffle the input array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
        /// Print the array in the form[x1, y1, x2, y2, ..., xn, yn].
        ///Example 1:
        ///Input: nums = [2,5,1,3,4,7], n = 3
        ///Output: [2,3,5,4,1,7]
        ///  Explanation: Since x1 = 2, x2 = 5, x3 = 1, y1 = 3, y2 = 4, y3 = 7 then the answer is [2,3,5,4,1,7].
        ///Example 2:
        ///Input: nums = [1,2,3,4,4,3,2,1], n = 4
        ///Output: [1,4,2,3,3,2,4,1]
        ///Example 3:
        ///Input: nums = [1,1,2,2], n = 2
        ///Output: [1,2,1,2]
        /// </summary>

        private static void ShuffleArray(int[] ar1, int n1)
        {
            try
            {
                int inputarray = ar1.Length;                                        // Declaring a variable for size of the array to use it in a loop
                int[] shuffledArray = new int[inputarray];                          // Creating an array for the required size
                int[] x = new int[n1];                                              // Data Type int used for array to store x values (first n values)
                int[] y = new int[n1];                                              // Data Type int used for array to store y values (first n values)
                for (int i = 0; i < inputarray; i++)
                {
                    if (i < n1)
                    {
                        x[i] = ar1[i];                                              // For first n1 values, i = 0 to i = n1-1
                    }
                    else
                    {
                        y[i - n1] = ar1[i];                                         // Last n1 values, i = n1 to i = size-1
                    }
                }
                int a = 0, b = 0, c = 0;
                while (a < n1 && b < n1)
                {
                    shuffledArray[c++] = x[a++];                                    // Stores elements obtained from x values and y values alternatively
                    shuffledArray[c++] = y[b++];
                }
                while (a < n1)
                    shuffledArray[c++] = x[a++];                                    // Checking and storing any element that is left behind from x values
                while (b < n1)
                    shuffledArray[c++] = y[b++];
                string split = "[";
                foreach (int count in shuffledArray)
                {
                    Console.Write(split + count);                                   // Printing the shuffled array with spaces between each element
                    split = ",";
                }
                Console.WriteLine("]");
                Console.WriteLine();
            }
            catch (Exception)
            {
                throw new Exception("Enter a valid Input");                        // Handles errors occured in the try block.
            }
        }

        //Question 2:
        /// <summary>
        /// Write a method to move all 0's to the end of the given array. You should maintain the relative order of the non-zero elements. 
        /// You must do this in-place without making a copy of the array.
        /// Example:
        ///Input: [0,1,0,3,12]
        /// Output: [1,3,12,0,0]
        /// </summary>

        private static void MoveZeroes(int[] ar2)
        {
            try
            {
                int inputarray = ar2.Length;                                        // Declaring a variable for size of the array to use it in a loop
                int count = 0;
                for (int i = 0; i < inputarray; i++)
                {
                    if (ar2[i] != 0)
                    {
                        ar2[count] = ar2[i];                                        // Starting with adjusting the non-zero values
                        count++;
                    }
                }
                while (count < inputarray)
                {
                    ar2[count] = 0;                                                 // Storing zeros at the end
                    count++;
                }
                string split = "[";
                foreach (int i in ar2)
                {
                    Console.Write(split + i);                                       // Printing the adjusted array with spaces between each element
                    split = ",";
                }
                Console.WriteLine("]");
            }
            catch (Exception)
            {
                throw new Exception("Enter a valid Input");                        // Handles errors occured in the try block.
            }
        }

        //Question 3
        /// <summary>
        /// For an array of integers - nums
        ///A pair(i, j) is called cool if nums[i] == nums[j] and i<j
        ///Print the number of cool pairs
        ///Example 1
        ///Input: nums = [1,2,3,1,1,3]
        ///Output: 4
        ///Explanation: There are 4 cool pairs (0,3), (0,4), (3,4), (2,5) 
        ///Example 3:
        ///Input: nums = [1, 2, 3]
        ///Output: 0
        ///Constraints: time complexity should be O(n).
        /// </summary>

        private static void CoolPairs(int[] ar3)
        {
            try
            {
                int CoolPairs = 0;
                int count = ar3.Length;                                              // Declaring a variable for size of the array to use it in a loop
                Dictionary<int, int> Dict = new Dictionary<int, int>();              // Creating Dictionary for storing the frequency
                for (int i = 0; i < count; i++)
                {
                    if (Dict.ContainsKey((int)ar3[i]))                               // Finding occurence frequency of each element of the input

                    {
                        Dict[(int)ar3[i]] += 1;
                    }
                    else
                    {
                        Dict.Add((int)ar3[i], 1);
                    }
                }
                foreach (KeyValuePair<int, int> k in Dict)                          // Calculating the cool pairs, depending on the frequency of occurence
                {
                    if (k.Value > 1)
                    {
                        CoolPairs += ((k.Value) * (k.Value - 1)) / 2;
                    }
                }
                Console.WriteLine(CoolPairs);                                       // Printing the number of Cool Pairs
            }
            catch (Exception)
            {
                throw new Exception("Enter a valid Input");                         // Handles errors occured in the try block.
            }
        }

        //Question 4:
        /// <summary>
        /// Given integer target and an array of integers, print indices of the two numbers such that they add up to the target.
        ///You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can print the answer in any order
        ///Example 1:
        ///Input: nums = [2,7,11,15], target = 9
        /// Output: [0,1]
        ///Output: Because nums[0] + nums[1] == 9, we print [0, 1].
        ///Example 2:
        ///Input: nums = [3,2,4], target = 6
        ///Output: [1,2]
        ///Example 3:
        ///Input: nums = [3,3], target = 6
        ///Output: [0,1]
        ///Constraints: Time complexity should be O(n)
        /// </summary>

        private static void TwoSum(int[] ar4, int target)
        {
            try
            {
                int[] TwoSumPair = new int[2];
                HashSet<int> hash = new HashSet<int>();                             // Declaring a Hashset for storing the element
                for (int i = 0; i < ar4.Length; i++)
                {
                    if (hash.Contains(target - ar4[i]))
                    {                                                               // Checking if we already have the difference
                        TwoSumPair[0] = target - ar4[i];
                        TwoSumPair[1] = i;                                          // Storing the index
                    }
                    hash.Add(ar4[i]);                                               // Adding the number to the hashset
                }
                for (int i = 0; i < ar4.Length; i++)
                {
                    if (TwoSumPair[0] == ar4[i])
                    {
                        TwoSumPair[0] = i;                                          // Storing the index
                    }
                }
                string split = "[";
                foreach (int count in TwoSumPair)
                {
                    Console.Write(split + count);                                   // Printing the output pair with spaces between each element
                    split = ",";
                }
                Console.WriteLine("]");
                Console.WriteLine();
            }
            catch (Exception)
            {
                throw new Exception("Enter a valid Input");                        // Handles errors occured in the try block.
            }
        }

        //Question 5:
        /// <summary>
        /// Given a string s and an integer array indices of the same length.
        ///The string s will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        ///Print the shuffled string.
        ///Example 1
        ///Input: s = "korfsucy", indices = [6,4,3,2,1,0,5,7]
        ///Output: "usfrocky"
        ///Explanation: As shown in the assignment document, “K” should be at index 6, “O” should be at index 4 and so on. “korfsucy” becomes “usfrocky”
        ///Example 2:
        ///Input: s = "USF", indices = [0,1,2]
        ///Output: "USF"
        ///Explanation: After shuffling, each character remains in its position.
        ///Example 3:
        ///Input: s = "ockry", indices = [1, 2, 3, 0, 4]
        ///Output: "rocky"
        /// </summary>

        private static void RestoreString(string s5, int[] indices)
        {
            try
            {
                char[] ToChar = s5.ToCharArray();                                                                   // To store characters of the input string in a Char array
                var charindices = indices.Zip(ToChar, (x, y) => new { x, y }).ToDictionary(a => a.x, a => a.y);     // To map the indices with respective characters
                var sortedcharindices = new SortedDictionary<int, char>(charindices);                               // To sort the dictionary according to the keys(indices)
                string ShuffledString = "";
                foreach (KeyValuePair<int, char> k in sortedcharindices)
                {
                    ShuffledString += k.Value;
                }
                Console.WriteLine("\"" + ShuffledString + "\"");
            }
            catch (Exception)
            {
                throw new Exception("Enter a valid Input");                                                         // Handles errors occured in the try block.
            }
        }

        //Question 6
        /// <summary>
        /// Determine whether two give strings s1 and s2, are isomorphic.
        ///Two strings are isomorphic if the characters in s1 can be replaced to get s2.
        ///All occurrences of a character must be replaced with another character while preserving the order of characters.
        ///No two characters may map to the same character but a character may map to itself.
        ///Example 1:
        ///Input:s1 = “bulls” s2 = “sunny” 
        ///Output : True
        ///Explanation: ‘b’ can be replaced with ‘s’ and similarly ‘u’ with ‘u’, ‘l’ with ‘n’ and ‘s’ with ‘y’.
        ///Example 2:
        ///Input: s1 = “usf” s2 = “add”
        ///Output : False
        ///Explanation: ‘u’ can be replaced with ‘a’, but ‘s’ and ‘f’ should be replaced with ‘d’ to produce s2, which is not possible. So False.
        ///Example 3:
        ///Input : s1 = “ab” s2 = “aa”
        ///Output: False
        /// </summary>

        private static bool Isomorphic(string s61, string s62)
        {
            try
            {
                char[] char1 = s61.ToCharArray();                                                   // Declaring a variable to convert the first string into characters
                char[] char2 = s62.ToCharArray();                                                   // Declaring a variable to convert the second string into characters
                Dictionary<char, char> hashmap = new Dictionary<char, char>();                      // Using hashmap to map the corresponding characters
                bool isIsomorphic = true;
                for (int i = 0; i < char1.Length; i++)
                {
                    if (hashmap.ContainsKey(char1[i]))
                    {
                        if (hashmap[char1[i]] == char2[i])
                        {
                            continue;
                        }
                        else
                        {
                            isIsomorphic = false;
                            break;
                        }
                    }
                    if (hashmap.ContainsValue(char2[i]))
                    {
                        var myKey = hashmap.FirstOrDefault(x => x.Value == char2[i]).Key;
                        if (char1[i] == myKey)
                        {
                            continue;
                        }
                        else
                        {
                            isIsomorphic = false;
                            break;
                        }
                    }
                    else
                    {
                        hashmap.Add(char1[i], char2[i]);
                    }
                }
                if (!isIsomorphic)
                {
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Enter a valid Input");                                                                                  // Handles errors occured in the try block.
            }
        }

        //Question 7
        /// <summary>
        /// Given a list of the scores of different students, items, where items[i] = [IDi, scorei] represents one score from a student with IDi, calculate each student's top five average.
        /// Print the answer as an array of pairs result, where result[j] = [IDj, topFiveAveragej] represents the student with IDj and their top five average.Sort result by IDj in increasing order.
        /// A student's top five average is calculated by taking the sum of their top five scores and dividing it by 5 using integer division.
        /// Example 1:
        /// Input: items = [[1, 91], [1,92], [2,93], [2,97], [1,60], [2,77], [1,65], [1,87], [1,100], [2,100], [2,76]]
        /// Output: [[1,87],[2,88]]
        /// Explanation: 
        /// The student with ID = 1 got scores 91, 92, 60, 65, 87, and 100. Their top five average is (100 + 92 + 91 + 87 + 65) / 5 = 87.
        /// The student with ID = 2 got scores 93, 97, 77, 100, and 76. Their top five average is (100 + 97 + 93 + 77 + 76) / 5 = 88.6, but with integer division their average converts to 88.
        /// Example 2:
        /// Input: items = [[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100]]
        /// Output: [[1,100],[7,100]]
        /// Constraints:
        /// 1 <= items.length <= 1000
        /// items[i].length == 2
        /// 1 <= IDi <= 1000
        /// 0 <= scorei <= 100
        /// For each IDi, there will be at least five scores.
        /// </summary>

        private static void HighFive(int[,] scores)
        {
            try
            {
                int RowStart = scores.GetLowerBound(0);
                int RowEnd = scores.GetUpperBound(0);
                int NumberOfRows = RowEnd - RowStart + 1;
                int ColumnStart = scores.GetLowerBound(1);
                int ColumnEnd = scores.GetUpperBound(1);
                int NumberOfColumns = ColumnEnd - ColumnStart + 1;
                int[][] newarray = new int[NumberOfRows][];                                     // To convert the 2D array to a jagged array(array of arrays)
                for (int i = 0; i < NumberOfRows; i++)
                {
                    newarray[i] = new int[NumberOfColumns];
                    for (int j = 0; j < NumberOfColumns; j++)
                    {
                        newarray[i][j] = scores[i + RowStart, j + ColumnStart];
                    }
                }
                Dictionary<int,
                int[]> Dict = new Dictionary<int, int[]>();                                     // Using Dictionary to store keys and values array
                foreach (int[] a in newarray)
                {
                    if (Dict.ContainsKey(a[0]))
                    {
                        int i = 0;
                        int[] flag = new int[Dict[a[0]].Length + 1];
                        foreach (int count in Dict[a[0]])
                        {
                            flag[i] = count;
                            i++;
                        }
                        flag[i] = a[1];
                        Dict[a[0]] = flag;
                    }
                    else
                    {
                        Dict[a[0]] = new int[] { a[1] };
                    }
                }
                Dictionary<int, int> average = new Dictionary<int, int>();                     // Using Dictionary to store the averages
                foreach (KeyValuePair<int, int[]> k in Dict)
                {
                    int sum = 0;
                    int[] flag = k.Value;
                    for (int x = 0; x < 5; x++)
                    {
                        int maxVal = flag.Max();
                        sum += maxVal;
                        int numIdx = Array.IndexOf(flag, maxVal);
                        List<int> flag2 = new List<int>(flag);
                        flag2.RemoveAt(numIdx);
                        flag = flag2.ToArray();
                    }
                    average[k.Key] = sum / 5;
                }
                Console.Write("[");
                foreach (KeyValuePair<int, int> k in average)
                {
                    Console.Write(" [" + k.Key + "," + k.Value + "] ");                                  // Printing the averages of students according to their IDs
                }
                Console.Write("]");
                Console.WriteLine();
            }
            catch (Exception)
            {
                throw new Exception("Enter a valid Input");                                              // Handles errors occured in the try block.
            }
        }

        //Question 8
        /// <summary>
        /// Write an algorithm to determine if a number n is happy.
        ///A happy number is a number defined by the following process:
        ///•	Starting with any positive integer, replace the number by the sum of the squares of its digits.
        ///•	Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
        ///•	Those numbers for which this process ends in 1 are happy.
        ///Return true if n is a happy number, and false if not.
        ///Example 1:
        ///Input: n = 19
        ///Output: true
        ///Explanation:
        ///12 + 92 = 82
        ///82 + 22 = 68
        ///62 + 82 = 100
        ///12 + 02 + 02 = 1
        ///Example 2:
        ///Input: n = 2
        ///Output: false
        ///Constraints:
        ///1 <= n <= 231 - 1
        /// </summary>

        private static bool HappyNumber(int n8)
        {
            try
            {
                char[] numchar = n8.ToString().ToCharArray();
                int[] intchar = Array.ConvertAll(numchar, c => (int)Char.GetNumericValue(c));               // To convert the number into a single digit
                while (intchar.Length > 1)
                {
                    int sum = 0;
                    for (int i = 0; i < intchar.Length; i++)
                    {
                        sum += (int)Math.Pow(intchar[i], 2);                                                // Squaring and Adding
                    }
                    numchar = sum.ToString().ToArray();
                    intchar = Array.ConvertAll(numchar, c => (int)Char.GetNumericValue(c));
                }
                if (intchar[0] == 1)                                                                        // Checking if the number is a Happy Number
                {
                    return true;                                                                            // Returning true when the condition of HappyNumber is satisfied
                }
                return false;
            }
            catch (Exception)
            {
                throw new Exception("Enter a valid Input");                                                 // Handles errors occured in the try block.
            }
        }

        //Question 9
        /// <summary>
        /// Professor Manish is planning to invest in stocks. He has the data of the price of a stock for the next n days.  
        /// Tell him the maximum profit he can earn from the given stock prices.Choose a single day to buy a stock and choose another day in the future to sell the stock for a profit
        /// If you cannot achieve any profit return 0.
        /// Example 1:
        /// Input: prices = [7,1,5,3,6,4]
        /// Output: 5
        /// Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        /// Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
        /// Example 2:
        /// Input: prices = [7,6,4,3,1]
        /// Output: 0
        ///Explanation: In this case, no transactions are done and the max profit = 0.
        ///Try to solve it in O(n) time complexity.
        /// </summary>

        private static int Stocks(int[] ar9)
        {
            try
            {
                int maxprofit = 0;
                int flag = -1;
                int a = ar9.Length;                                                                    // Declaring a variable for size of the array to use it in a loop
                for (int i = 0; i < a; i++)
                {                                                                                      // To compute minimum stock to buy through if statements
                    if (flag < 0)
                    {
                        flag = ar9[i];
                    }
                    if (flag > ar9[i])
                    {
                        flag = ar9[i];                                                                 // Writing the greater value to flag to check for profit
                    }
                    else                                                                               // To compute maximum profit using else statement
                    {
                        if (ar9[i] - flag > maxprofit)
                        {
                            maxprofit = ar9[i] - flag;                                                 // Writing the final value of profit to maxprofit variable
                        }
                    }
                }
                return maxprofit;                                                                      // Returning the final value of maxprofit
            }
            catch (Exception)
            {
                throw new Exception("Enter a valid Input");                                            // Handles errors occured in the try block.
            }
        }

        //Question 10
        /// <summary>
        /// Professor Clinton is climbing the stairs in the Muma College of Business. He generally takes one or two steps at a time.
        /// One day he came across an idea and wanted to find the total number of unique ways that he can climb the stairs. Help Professor Clinton.
        /// Print the number of unique ways. 
        /// Example 1:
        ///Input: n = 2
        ///Output: 2
        ///Explanation: There are two ways to climb to the top.
        ///1. 1 step + 1 step
        ///2. 2 steps
        ///Example 2:
        ///Input: n = 3
        ///Output: 3
        ///Explanation: There are three ways to climb to the top.
        ///1. 1 step + 1 step + 1 step
        ///2. 1 step + 2 steps
        ///3. 2 steps + 1 step
        ///Hint : Use the concept of Fibonacci series.
        /// </summary>

        private static void Stairs(int n10)
        {
            try
            {
                int steps = n10 + 1;
                int[] count = new int[steps + 1];
                count[0] = 0;
                count[1] = 1;
                for (int i = 2; i <= steps; i++)                                                                // Using Fibonacci series logic to compute the number of ways to climb the steps
                {
                    count[i] = count[i - 2] + count[i - 1];
                }
                Console.WriteLine(count[steps]);
                Console.WriteLine();
            }
            catch (Exception)
            {
                throw new Exception("Enter a valid Input");                                                    // Handles errors occured in the try block.
            }
        }
    }
}