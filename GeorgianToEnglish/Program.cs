using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeorgianToEnglish
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Input: Georgian text
            string georgianText = "ვემზადებით დიდი პროექტისათვის";

            // Dictionary to map Georgian letters to English
            Dictionary<char, string> georgianToEnglish = new Dictionary<char, string>()
            {
                {'ა', "a"}, {'ბ', "b"}, {'გ', "g"}, {'დ', "d"}, {'ე', "e"},
                {'ვ', "v"}, {'ზ', "z"}, {'თ', "t"}, {'ი', "i"}, {'კ', "k"},
                {'ლ', "l"}, {'მ', "m"}, {'ნ', "n"}, {'ო', "o"}, {'პ', "p"},
                {'ჟ', "zh"}, {'რ', "r"}, {'ს', "s"}, {'ტ', "t"}, {'უ', "u"},
                {'ფ', "ph"}, {'ქ', "k"}, {'ღ', "gh"}, {'ყ', "q"}, {'შ', "sh"},
                {'ჩ', "ch"}, {'ც', "ts"}, {'ძ', "dz"}, {'წ', "ts"}, {'ჭ', "ch"},
                {'ხ', "kh"}, {'ჯ', "j"}, {'ჰ', "h"}
            };

            // Transliterating Georgian to English
            string englishText = "";
            foreach (char letter in georgianText)
            {
                if (georgianToEnglish.ContainsKey(letter))
                {
                    englishText += georgianToEnglish[letter];
                }
                else
                {
                    englishText += letter; // Leave it as it is if no mapping found
                }
            }

            // Output: Transliterated text
            Console.WriteLine("Transliterated: " + englishText);

            Console.ReadKey();
        }
    }
}
