using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace l2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----- IMPLICIT TYPING -----
            // You can use var to have C# figure out the 
            // data type

            var intVal = 1234;

            Console.WriteLine("intVal Type : {0}",
                intVal.GetType());

            // ----- ARRAYS -----
            // Arrays are just boxes inside of a bigger box
            // that can contain many values of the same
            // data type
            // Each item is assigned a key starting at 0
            // and incrementing up from there

            // Define an array which holds 3 values
            // Arrays have fixed sizes
            int[] favNums = new int[3];

            // Add a value to the array
            favNums[0] = 23;

            // Retrieve a value 
            Console.WriteLine("favNum 0 : {0}", favNums[0]);

            // Create and fill array
            string[] customers = { "Bob", "Sally", "Sue" };

            // You can use var to create arrays, but the
            // values must be of the same type
            var employees = new[] { "Mike", "Paul", "Rick" };

            // Create an array of base objects which is the 
            // base type of all other types
            object[] randomArray = { "Paul", 45, 1.234 };

            // GetType knows its true type
            Console.WriteLine("randomArray 0 : {0}",
                randomArray[0].GetType());

            // Get number of items in array
            Console.WriteLine("Array Size : {0}",
                randomArray.Length);

            // Use for loop to cycle through the array
            for (int i = 0; i < randomArray.Length; i++)
            {
                Console.WriteLine("Array {0} : Value : {1}",
                i, randomArray[i]);
            }

            // Multidimensional arrays
            // When you define an array like arrName[5] you
            // are saying you want to create boxes stacked 
            // vertically

            // If you define arrName[2,2] you are saying
            // you want to have 2 rows high and 2 across
            string[,] custNames = new string[2, 2] { { "Bob", "Smith" }, { "Sally", "Smith" } };

            // Get value in MD array
            Console.WriteLine("MD Value : {0}",
                custNames.GetValue(1, 1));

            // Cycle through the multidimensional array
            // Get length of multidimensional array column
            for (int i = 0; i < custNames.GetLength(0); i++)
            {
                // Get length of multidimensional array row
                for (int j = 0; j < custNames.GetLength(1); j++)
                {
                    Console.Write("{0} ", custNames[i, j]);
                }
                Console.WriteLine();
            }

            // An array like arrName[2,2,3] would be like a 
            // stack of 3 spread sheets with 2 rows and 2
            // columns worth of data on each page

            // foreach can be used to cycle through an array
            int[] randNums = { 1, 4, 9, 2 };

            // You can pass an array to a function
            PrintArray(randNums, "ForEach");

            // Sort array
            Array.Sort(randNums);

            // Reverse array
            Array.Reverse(randNums);

            // Get index of match or return -1
            Console.WriteLine("1 at index : {0} ",
                Array.IndexOf(randNums, 1));

            // Change value at index 1 to 0
            randNums.SetValue(0, 1);

            // Copy part of an array to another
            int[] srcArray = { 1, 2, 3 };
            int[] destArray = new int[2];
            int startInd = 0;
            int length = 2;

            Array.Copy(srcArray, startInd, destArray,
                startInd, length);

            PrintArray(destArray, "Copy");

            // Create an array with CreateInstance
            Array anotherArray = Array.CreateInstance(typeof(int), 10);

            // Copy values in srcArray to destArray starting
            // at index 5 in destination
            srcArray.CopyTo(anotherArray, 5);

            foreach (int m in anotherArray)
            {
                Console.WriteLine("CopyTo : {0} ", m);
            }

            // Search for an element that matches the conditions
            // defined by the specified predicate
            int[] numArray = { 1, 11, 22 };
            Console.WriteLine("> 10 : {0}", Array.Find(numArray, GT10));

            // FindAll returns an array with all values that
            // match 
            // FindIndex returns the index of the match


            // ----- STRINGBUILDER -----
            // Each time you change a string you are actually
            // creating a new string which is inefficient
            // when you are working with large blocks of text
            // StringBuilders actually change the text
            // rather then make a copy

            // Create a StringBuilder with a default size
            // of 16 characters, but it grows automatically
            StringBuilder sb = new StringBuilder("Random Text");

            // Create a StringBuilder with a size of 256
            StringBuilder sb2 = new StringBuilder("More Stuff that is very important", 256);

            // Get max size
            Console.WriteLine("Capacity : {0}", sb2.Capacity);

            // Get length
            Console.WriteLine("Length : {0}", sb2.Length);

            // Add text to StringBuilder
            sb2.AppendLine("\nMore important text");

            // Define culture specific formating
            CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");

            // Append a format string
            string bestCust = "Bob Smith";
            sb2.AppendFormat(enUS, "Best Customer : {0}", bestCust);

            // Output StringBuilder
            Console.WriteLine(sb2.ToString());

            // Replace a string
            sb2.Replace("text", "characters");
            Console.WriteLine(sb2.ToString());

            // Clear a string builder
            sb2.Clear();

            sb2.Append("Random Text");

            // Are objects equal
            Console.WriteLine(sb.Equals(sb2));

            // Insert at an index
            sb2.Insert(11, " that's Great");

            Console.WriteLine("Insert : {0}", sb2.ToString());

            // Remove number of characters starting at index
            sb2.Remove(11, 7);

            Console.WriteLine("Remove : {0}", sb2.ToString());

            // ----- CASTING -----
            // If you want to cast from one type to another
            long num1 = 1234;
            int num2 = (int)num1;

            Console.WriteLine("Orig : {0} Cast : {1}",
                num1.GetType(), num2.GetType());


            Console.ReadLine();

        }

        static void PrintArray(int[] intArray, string mess)
        {
            foreach (int k in intArray)
            {
                Console.WriteLine("{0} : {1} ", mess, k);
            }
        }

        private static bool GT10(int val)
        {
            return val > 10;
        }
    }
}
