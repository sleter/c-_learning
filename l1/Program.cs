using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Numerics;

// You use a namespace to define globally unique objects
namespace CSharpTutA.cs
{
    // A class defines the variables and methods used
    // by objects. I'll get more into this later
    class Program
    {
        // The main function is where execution begins
        // static functions belong to the class and 
        // can be executed without needing to create 
        // an object
        // void means that this function doesn't return
        // a value after it executes, but it is 
        // common to use int instead and return an 
        // integer value 0 : when successfully executed
        // or -1 when an error occurred
        // This function can receive multiple string
        // values that are saved into an array

        static void Main(string[] args)
        {

            // Write a string to the console followed
            // be a newline
            // Write() doesn't include a newline
            // The Console class provides functions for input
            // output and error streams for console applications
            Console.WriteLine("Hello World");

            // for loops allow you to cycle through information
            // We will get command line arguments passed and print
            // them

            for (int i = 0; i < args.Length; i++)
            {
                // We use format parameters to place the string
                // version of passed objects into the output
                Console.WriteLine("Arg {0} : {1}", i, args[i]);
            }

            // Passing command line arguments in Visual Studio
            // Right click on project name in Solution Explorer 
            // Select Properties
            // Select Debug tab on the left
            // Enter parameters in Command Line Arguments textbox
            // Click Start

            // Get an array of the command line arguments
            string[] myArgs = Environment.GetCommandLineArgs();

            // Use the Join function to combine arguments with a comma
            Console.WriteLine(string.Join(", ", myArgs));

            // Call for the function to execute
            // SayHello();

            // ---------- DATA TYPES ----------

            // Bools store true or false
            bool canIVote = true;

            // INTEGERS
            // Integers are 32-bit signed integers
            Console.WriteLine("Biggest Integer : {0}", int.MaxValue);
            Console.WriteLine("Smallest Integer : {0}", int.MinValue);

            // LONGS
            // Longs are 64-bit signed integers
            Console.WriteLine("Biggest Long : {0}", long.MaxValue);
            Console.WriteLine("Smallest Long : {0}", long.MinValue);

            // DECIMALS
            // Decimals store 128-bit precise decimal values
            // It is accurate to 28 digits
            decimal decPiVal = 3.1415926535897932384626433832M;
            decimal decBigNum = 3.00000000000000000000000000011M;
            Console.WriteLine("DEC : PI + bigNum = {0}", decPiVal + decBigNum);

            Console.WriteLine("Biggest Decimal : {0}", Decimal.MaxValue);

            // DOUBLES
            // Doubles are 64-bit float types
            Console.WriteLine("Biggest Double : {0}", Double.MaxValue.ToString("#"));

            // It is precise to 14 digits
            double dblPiVal = 3.14159265358979;
            double dblBigNum = 3.00000000000002;
            Console.WriteLine("DBL : PI + bigNum = {0}", dblPiVal + dblBigNum);

            // FLOATS
            // Floats are 32-bit float types
            Console.WriteLine("Biggest Float : {0}", float.MaxValue.ToString("#"));

            // It is precise to 6 digits
            float fltPiVal = 3.141592F;
            float fltBigNum = 3.000002F;
            Console.WriteLine("FLT : PI + bigNum = {0}", fltPiVal + fltBigNum);

            // Other Data Types
            // byte : 8-bit unsigned int 0 to 255
            // char : 16-bit unicode character
            // sbyte : 8-bit signed int 128 to 127
            // short : 16-bit signed int -32,768 to 32,767
            // uint : 32-bit unsigned int 0 to 4,294,967,295
            // ulong : 64-bit unsigned int 0 to 18,446,744,073,709,551,615
            // ushort : 16-bit unsigned int 0 to 65,535

            // You can convert from string to other types with Parse
            bool boolFromStr = bool.Parse("True");
            int intFromStr = int.Parse("100");
            double dblFromStr = double.Parse("1.234");

            // ---------- DATETIME & TIMESPAN ----------

            // Used to define dates
            DateTime awesomeDate = new DateTime(1974, 12, 21);
            Console.WriteLine("Day of Week : {0}", awesomeDate.DayOfWeek);

            // You can change values
            awesomeDate = awesomeDate.AddDays(4);
            awesomeDate = awesomeDate.AddMonths(1);
            awesomeDate = awesomeDate.AddYears(1);
            Console.WriteLine("New Date : {0}", awesomeDate.Date);

            // TimeSpan
            // Used to define a time
            TimeSpan lunchTime = new TimeSpan(12, 30, 0);

            // Change values
            lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));
            lunchTime = lunchTime.Add(new TimeSpan(1, 0, 0));
            Console.WriteLine("New Time : {0}", lunchTime.ToString());

            // ---------- BIGINTEGER ----------
            // Used to store very large numbers
            // Select Project -> Add Reference
            // Select Assemblies -> System.Numerics.dll click Ok
            // Add this line using System.Numerics; at the top

            // Define the value using a text literal
            BigInteger bigNum = BigInteger.Parse("12345123451234512345");
            Console.WriteLine("Big Num * 2 = {0}", bigNum * 2);


            // ---------- FORMATTING OUTPUT ----------

            // Format output for currency
            Console.WriteLine("Currency : {0:c}", 23.455);

            // Pad with zeroes 
            Console.WriteLine("Pad with 0s : {0:d4}", 23);

            // Define decimals 
            Console.WriteLine("3 Decimals : {0:f3}", 23.4555);

            // Add commas and decimals
            Console.WriteLine("Commas : {0:n4}", 2300);

            // ---------- STRINGS ----------
            // Strings store a series of characters
            string randString = "This is a string";

            // Get number of characters in string
            Console.WriteLine("String Length : {0}", randString.Length);

            // Check if string contains other string
            Console.WriteLine("String Contains is : {0}",
                randString.Contains("is"));

            // Index of string match
            Console.WriteLine("Index of is : {0}",
                randString.IndexOf("is"));

            // Remove number of characters starting at an index
            Console.WriteLine("Remove string : {0}",
                randString.Remove(10, 6));

            // Add a string starting at an index
            Console.WriteLine("Insert String : {0}",
                randString.Insert(10, "short "));

            // Replace a string with another
            Console.WriteLine("Replace String : {0}",
                randString.Replace("string", "sentence"));

            // Compare strings and ignore case
            // < 0 : str1 preceeds str2
            // = : Zero
            // > 0 : str2 preceeds str1
            Console.WriteLine("Compare A to B : {0}",
                String.Compare("A", "B", StringComparison.OrdinalIgnoreCase));

            // Check if strings are equal
            Console.WriteLine("A = a : {0}",
                String.Equals("A", "a", StringComparison.OrdinalIgnoreCase));

            // Add padding left
            Console.WriteLine("Pad Left : {0}",
                randString.PadLeft(20, '.'));

            // Add padding right
            Console.WriteLine("Pad Right : {0} Stuff",
                randString.PadRight(20, '.'));

            // Trim whitespace
            Console.WriteLine("Trim : {0}",
                randString.Trim());

            // Make uppercase
            Console.WriteLine("Uppercase : {0}",
                randString.ToUpper());

            // Make lowercase
            Console.WriteLine("Lowercase : {0}",
                randString.ToLower());

            // Use Format to create strings
            string newString = String.Format("{0} saw a {1} {2} in the {3}",
                "Paul", "rabbit", "eating", "field");

            // You can add newlines with \n and join strings with +
            Console.Write(newString + "\n");

            // Other escape characters
            // \' \" \\ \t \a

            // Verbatim strings ignore escape characters
            Console.Write(@"Exactly What I Typed");

            // Excepts input up until a newline, but it is here to 
            // keep the console open after output
            // Read() excepts a single character
            Console.ReadLine();

        }

        // You can create your own functions (methods)
        private static void SayHello()
        {
            // Defines a variable that will store a string
            // of characters
            string name = "";

            Console.Write("What is your name : ");

            // Save the input the user provides
            name = Console.ReadLine();

            Console.WriteLine("Hello {0}", name);
        }

    }
}