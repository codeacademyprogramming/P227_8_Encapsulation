using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "Salam    Hikmet     necesen";
            MakeSentence(ref word);
            Console.WriteLine(word);

            word = "Salam123 dfds fds fsfds fdsf dsfds fds fdsf dsfds fdsf dsf";

            Console.WriteLine(Check(word));

            Console.WriteLine(FindFirstWord("Hello    World, fdfd"));

            Console.WriteLine(CheckFullName(""));
        }

        static void MakeSentence(ref string str)
        {
            string newStr = "";

            str = str.Trim();

            for(int i = 0; i < str.Length; i++)
            {
                if((str[i] != ' ') || (str[i+1]!=' '))
                {
                    newStr += str[i];
                }
            }

            str = newStr;
        }

        static bool Check(string str)
        {
            bool hasDigit = false;
            bool hasUpper = false;
            bool hasLower = false;

            for(int i = 0;i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                    hasDigit = true;
                else if (Char.IsUpper(str[i]))
                    hasUpper = true;
                else if (Char.IsLower(str[i]))
                    hasLower = true;

                if (hasDigit && hasLower && hasUpper)
                    return true;
            }

            return false;
        }

        static string FindFirstWord(string str)
        {
            string word;

            str = str.Trim();

            int indexOfSpace = str.IndexOf(' ');
            int indexOfVergul = str.IndexOf(',');

            if (indexOfVergul > -1 && (indexOfSpace == -1 || indexOfVergul < indexOfSpace))
                word = str.Substring(0, indexOfVergul);
            else if (indexOfSpace > -1 && (indexOfVergul == -1 || indexOfSpace < indexOfVergul))
                word = str.Substring(0, indexOfSpace);
            else word = str;

            return word;
        }

        static bool CheckFullName(string fullname)
        {
            MakeSentence(ref fullname);
            var words = fullname.Split(' ');

            if (words.Length == 2 && Char.IsUpper(words[0][0]) && Char.IsUpper(words[1][0]))
                return true;
            else return false;
        }
    }
}
