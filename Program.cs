using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_1_Spring_2021
{
    class Program
    {
        // Print a * Traingle
        private static int printTriangle(int n)       // defining the code to be executed for the Triangle program
        {
            try
            {
                if (n <= 0)                              // defining basic criteria for the code to run
                    return n;
                int i, j, k = 1;                        // declaring variables for the program
                k = n - 1;
                for (j = 1; j <= n; j++)
                {
                    // Printing Space  
                    for (i = 1; i <= k; i++)            // loop for printing space, row wise
                        Console.Write(" ");
                    k--;
                    // Printing *  
                    for (i = 1; i <= 2 * j - 1; i++)    // loop for printing *, row wise
                        Console.Write("*");
                    Console.WriteLine();                // to go to next line and start the next row
                }

                return n;
            }

            catch (Exception e)
            {

                Console.WriteLine("Please enter a valid input " + e.Message);                    // to throw an alert message for an invalid input
                throw;
            }


        }

        // Print pell number series
        private static int PrintPellSeries(int n2)  // defining the code to be executed for the Pell Series program
        {
            try
            {

                if (n2 < 2)                            // defining basic criteria for the code to run
                    return n2;
                int a = 0;
                int b = 1;                              // declaring first 2 variables of the pell series
                Console.Write(a + " ");
                Console.Write(b + " ");                 // printing first 2 variables of the pell series
                int c;                                  // defining a variable for the third term of the pell series
                for (int i = 3; i <= n2; i++)           // using for loop to calculate the next terms of the pell series
                {
                    c = 2 * b + a;                      // formula to calculate the next number in the pell series
                    a = b;                              // reassigning variables for further computations,ex: second to first variable
                    b = c;                              // reassigning variables for further computations,ex: third to second variable 
                    Console.Write(b + " ");             // printing the computed number of the pell series
                }

                return b;
            }

            catch (Exception e)
            {

                Console.WriteLine("Please enter a valid input " + e.Message);                    // to throw an alert message for an invalid input
                throw;
            }
        }

        //Check for a number if it can be expressed as sum of squares of integers
        private static bool squareSums(int n3)      // defining the code using bool (to check for true or false) to be executed for the Sum of Squares program
        {
            try
            {
                int i, j;                               // declaring variables for the program
                for (i = 0; i * i <= n3; i++)           // using for loop to start checking from integer 0 for variables i and j
                    for (j = 0; j * j <= n3; j++)
                        if (i * i + j * j == n3)        // calculating and checking for each integer value of i and j
                        {
                            return true;
                        }
                return false;
            }

            catch (Exception e)
            {

                Console.WriteLine("Please enter a valid input " + e.Message);                    // to throw an alert message for an invalid input
                throw;
            }

        }



        private static int diffPairs(int[] pairs, int k)                             // defining the code to be executed to find the number of unique n-diff pairs in the array

        {
            try
            {

                if (k < 0)                                                       // condition to tackle invlaid input
                    return 0;

                int result = 0;
                System.Collections.Hashtable store = new System.Collections.Hashtable();     // declaring a hashtabel to store unique values

                foreach (var pair in pairs)                                                  // adding unique pairs to hash table
                    if (!store.ContainsKey(pair))
                        store.Add(pair, 1);
                    else
                        store[pair] = (int)store[pair] + 1;                                   // updating hashtable with existing pairs

                foreach (var pair in store.Keys)                                             // incrementing the value for every pair found satisying the input k=0
                    if (k == 0)
                    {
                        if ((int)store[pair] > 1)
                            result++;
                    }
                    else if (store.ContainsKey((int)pair + k))                               // incrementing the value for every pair found satisying the input k>0
                        result++;

                return result;                                                              // returning the answer for the question
            }

            catch (Exception e)
            {

                Console.WriteLine("Please enter a valid input " + e.Message);                    // to throw an alert message for an invalid input
                throw;
            }

        }

        private static int UniqueEmails(List<string> emails)                                     // defining the code to be executed to compute how many different addresses actually receive mails?
        {
            try
            {

                List<string> Unique_Emails = new List<string>();

                foreach (string email in emails)                                                // checking by storing each emails
                {
                    string givenemail = "";

                    foreach (char a in email)
                    {
                        if (a == '@' || a == '+')                                               // condition to skip the content after + and @ characters
                        {
                            break;
                        }
                        if (a == '.')                                                          // condition to ignore . characters
                        {
                            continue;
                        }
                        givenemail += a;                                                       // 
                    }


                    int atIndex = email.IndexOf('@');                                         // combining the domain part with @ character
                    givenemail += email.Substring(atIndex);

                    if (Unique_Emails.Contains(givenemail) != true)                           // ignoring the emails that are already added
                    {
                        Unique_Emails.Add(givenemail);
                    }
                }
                return Unique_Emails.Count;
            }

            catch (Exception e)
            {

                Console.WriteLine("Please enter a valid input " + e.Message);                    // to throw an alert message for an invalid input
                throw;
            }

        }


        private static string DestCity(string[,] paths)                                 // defining the code to be executed to find the destination city
        {
            try
            {
                for (int j = 0; j < paths.GetLength(0); j++)
                {
                    int a = 0;
                    for (int i = 0; i < paths.GetLength(0); i++)
                    {
                        if (paths[i, 0] == paths[j, 1])                             // checking for different origin and destination; removing when they are equal
                        {
                            a = 1;
                            break;

                        }
                    }
                    if (a == 0)
                    {
                        return paths[j, 1];                                       // returning the destination city  

                    }
                }
                return "";


            }
            catch (Exception e)
            {

                Console.WriteLine("Please enter a valid input " + e.Message);                    // to throw an alert message for an invalid input
                throw;
            }

        }
        // Driver functions to execute various codes


        public static void Main()
        {
            // Question 1
            Console.WriteLine("Q1:\n Enter number of rows for triangle:");
            int n = Convert.ToInt32(Console.ReadLine());                            // Reading the value for number of rows to be printed
            Console.WriteLine();
            printTriangle(n);                                                       // Calling the function for the triangle program
            Console.WriteLine("\n" + "* Traingle Printed" + "\n");

            // Question 2
            Console.WriteLine("Q2:\nGive a number for pell series");
            int n2 = Convert.ToInt32(Console.ReadLine());                           // Reading the value for number of integers to be printed in pell series
            Console.WriteLine();
            PrintPellSeries(n2);                                                    // Calling the function for the pell series program
            Console.WriteLine("\n" + "Pell Numbers Printed" + "\n", n2);

            // Question 3
            Console.WriteLine("Q3:\nGive a number to check");
            int n3 = Convert.ToInt32(Console.ReadLine());                           // Reading the value for number to be checked for sum of squares
            Console.WriteLine();
            bool flag = squareSums(n3);                                             // Using boolean, Calling the function for checking sum of squares for the input received
            if (flag)                                                               // Condition to execute based on the boolean value returned
            {
                Console.WriteLine("Yes, the number can be expressed as a sum of squares of 2 integers");
            }
            else
            {
                Console.WriteLine("No, the number cannot be expressed as a sum of squares of 2 integers");
            }
            Console.WriteLine("\n" + "Number checked for square sums" + "\n");

            // Question 4
            int[] arr = { 3, 1, 4, 1, 5 };
            Console.WriteLine("Q4:\nEnter the absolute difference to check");
            int k = Convert.ToInt32(Console.ReadLine());                                        // Reading the input for the difference to be checked
            int n4 = diffPairs(arr, k);                                                         // Calling the function to check for the pairs satisfying the difference
            Console.WriteLine("\nThere exists {0} pairs with the given difference" + "\n", n4);

            // Question 5
            List<string> emails = new List<string>();

            Console.WriteLine("Q5:\nEmail Program:");
            emails.Add("dis.email + bull@usf.com");                                         // Giving the input for the emails to be checked 
            emails.Add("dis.e.mail+bob.cathy@usf.com");
            emails.Add("disemail+david@us.f.com");
            int ans5 = UniqueEmails(emails);                                                // Calling the function to check for the number of unique emails in the given list

            Console.WriteLine("\nThe number of unique emails is " + ans5 + "\n");

            //Quesiton 6
            string[,] paths = new string[,] { { "London", "New York" }, { "New York", "Tampa" }, { "Delhi", "London" } };  // Giving input of path to be checked for the destination city
            string destination = DestCity(paths);                                                                          // Calling the function to check for the destination city
            Console.WriteLine("Q6:\nFinding the destination city:\n");

            Console.WriteLine("Destination city is " + destination);


        }

    }
}
