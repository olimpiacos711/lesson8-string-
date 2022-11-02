using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    internal class Program
    {
        static bool Compare(string firstString, string secondString)
        {
            if(String.Equals(firstString, secondString))
                return true;
            else
                return false;
        }

        static void Analyze(string firstString, int letters, int numbers, int symbols)
        {
            int isLetter = 0, isNumber = 0, isSymbol = 0;
            for (int i = 0; i < firstString.Length; i++)
            {
                if (firstString[i] >= 'a' && firstString[i] <= 'z' || firstString[i] >= 'A' && firstString[i] <= 'Z')
                    isLetter++;
                else
                if (firstString[i] >= '0' && firstString[i] <= '9')
                        isNumber++;
                else
                    isSymbol++;
            }
            Console.WriteLine($"Number of letters: {isLetter}");
            Console.WriteLine($"Number of digits: {isNumber}");
            Console.WriteLine($"Number of symbols: {isSymbol}");
        }

        static void Sort(string sortingString)
        {
            char temp;
            string str = sortingString.ToLower();
            char[] charstr = str.ToCharArray();
            for(int i = 1; i < charstr.Length; i++)
            {
                for(int j = 0; j < charstr.Length - 1; j++)
                {
                    if (charstr[j] > charstr[j + 1])
                    {
                        temp = charstr[j];
                        charstr[j] = charstr[j + 1];
                        charstr[j + 1] = temp; 
                    }
                }
            }
            Console.WriteLine(charstr);
        }

        static void Dublicate(string dublicateString)
        {
            var dublicates = new List<char>();
            foreach(var item in dublicateString)
            {
                int charCount = 0;
                foreach(var chars in dublicateString)
                {
                    if (item == chars)
                        charCount++;
                }
                if(charCount > 1 && !dublicates.Contains(item))
                    dublicates.Add(item);
            }
            Console.WriteLine(string.Join(", ", dublicates));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter first string: ");
            string first = Console.ReadLine();
            Console.WriteLine("Enter second string: ");
            string second = Console.ReadLine();

            bool compare = Compare(first, second);
            Console.WriteLine(compare);

            int letter = 0, number = 0, symbol = 0;
            Analyze(first, letter, number, symbol);

            Sort(first);

            Dublicate(first);
        }
    }
}
