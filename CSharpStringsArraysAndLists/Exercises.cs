using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStringsArraysAndLists
{
    public class Exercises
    {
        // The first four exercises can be procedures if you wish
        // Please add appropriate calling code to Program.cs

        // Add tests as well as calling code for the exercises where you use functions

        // 1: Arrays
        // Create an array of doubles each of which holds three coordinates
        // Print these to the screen
        public static void arraycords(double a, double b, double c, double d, double e, double f)
        {
            double[,] threecoords = new double[3,2];
            threecoords[0,0] = a;
            threecoords[0,1] = b;
            threecoords[1,0] = c;
            threecoords[1,1] = d;
            threecoords[2,0] = e;
            threecoords[2,1] = f;
            Console.WriteLine(Examples.PrintCoordinates(threecoords));
        }
        // 2: Byte Arrays
        // i) Create an array of bytes that represents the word hello. Convert this to a string and output the result.
        // ii) Convert the word hello both in Chinese and in English to bytes. Output the byte array. 
        public static string bytething(string word)
        {
            byte[] array = Encoding.ASCII.GetBytes(word);
            return string.Join(" ", array);
        }
        public static string stringthing(UTF32Encoding[] byteword)
        {
            List<string> b = new List<string>();
            foreach (UTF32Encoding i in byteword) {
                 b.Add(Convert.ToString(i));
            }
            return string.Join("",b);
        }
        // 3: Temperatures
        // Populate a list of doubles to represent daily temperatures over two weeks
        // Calculate and output the min, max and average temperatures over the time period
        // Sort the list in ascending order and print it out
        public static void tempaverages()
        {
            double temp = 0;
            List<double> twoweeks = new List<double>();
            for (int i = 0; i < 14; i++)
            {
                Console.WriteLine("What was the temperature today? ");
                temp = Convert.ToDouble(Console.ReadLine());
                twoweeks.Add(temp);
            }
            twoweeks.Sort();
            double total = twoweeks.Sum();
            
            Console.WriteLine($"The max temperature this week was {twoweeks.Last()}, the minimum temperature was {twoweeks.First()} and the average was {total/twoweeks.Count}");
        }
        // 4: Students
        // Populate a list of student data with a firstname, surname and date of birth. Use a tuple.
        // Print the names of the oldest and youngest students
        // Print out how many students were born after 2010
        // Create a new list of strings with the full names of all the students and print this out     

        // 5: Pig Latin
        // Move the first letter of each word to the end of it, then add "ay" to the end of the word. 
        // Leave punctuation marks untouched.
        // The cat sat on the mat. => heTay atcay noay hetay atmay.
        public static string PigLatin(string input)
        {
            throw new NotImplementedException();
        }

        // 6. Mexican wave
        //  1.  The input string will always be lower case but maybe empty.
        //  2.  If the character in the string is whitespace then pass over it as if it was an empty seat
        // Example
        // Wave("hello") => ["Hello", "hEllo", "heLlo", "helLo", "hellO"]
        public static List<string> Wave(string input)
        {
            throw new NotImplementedException();
        }

        // 7. Anagram
        // Given a word and a list of words return the number of words that are anagrams of the others
        // Anagram("star", ["rats", "arts", "arc"]) => 2
        public static int Anagram(string input, string[] possibleAnagrams)
        {
            throw new NotImplementedException();
        }

        // 8. Variable Name helper
        public enum VariableNameType
        {
            CamelCase,
            PascalCase,
            SnakeCase
        }
        // Return the string in either camelCase, PascalCase or snake_case depending on the user choice
        public static string WriteVariableName(string input, VariableNameType caseNeeded = VariableNameType.CamelCase)
        {
            throw new NotImplementedException();
        }

        // 9. Binary search
        // The function should take a sorted list. You can sort it in the calling code using default sort.
        // Use a binary search to find the requested value (write this yourself)
        // It should return the index of the value found or -1 if it isn't found
        public static int BinarySearch(List<decimal> values)
        {
            throw new NotImplementedException();
        }
    }
}
