using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm_Practice
{
    public class Program
    {
        static string Encode(string text)
        {
            text = text.ToUpper();
            var mapper = new Dictionary<char, string>()
            {
                { 'A', "11"}, {'B', "12"}, {'C', "13" }, {'D', "14"}, {'E', "15"},
                { 'F', "21"}, {'G', "22"}, {'H', "23" }, {'I', "24"}, {'J', "25"},
                { 'L', "31"}, {'M', "32"}, {'N', "33" }, {'O', "34"}, {'P', "35"},
                { 'Q', "41"}, {'R', "42"}, {'S', "43" }, {'T', "44"}, {'U', "45"},
                { 'V', "51"}, {'W', "52"}, {'X', "53" }, {'Y', "54"}, {'Z', "55"}
            };
            var textarray = text.ToCharArray();
            var coded = new List<string>();
            foreach (var ch in textarray)
            {
                foreach (var item in mapper)
                {   if (ch == 'K')
                    {
                        coded.Add("13");
                    }
                    if (item.Key == ch)
                        coded.Add(item.Value);
                }
            }

            var outputString = "";
            coded.ForEach(item => outputString += ToDots(item));
            return outputString.TrimEnd();
        }
        static string ToDots(string value)
        {
            return $"{String.Concat(Enumerable.Repeat(".", (int)Char.GetNumericValue(value[0])))} {String.Concat(Enumerable.Repeat(".", (int)Char.GetNumericValue(value[1])))} ";
        }

        static void Main(string[] args)
        {
            var output = Encode("rat");
            Console.WriteLine(output);
                 
        }


    }
}
