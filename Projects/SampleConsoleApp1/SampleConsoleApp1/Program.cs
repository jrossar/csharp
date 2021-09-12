using System;

namespace ZigZagConversion
{
    class ZigZag
    {
        static string GetNewString(int rows, string theString)
        {
            if (rows == 1) return theString;
            bool adding = true;
            int tracker = 0;
            string returnString = "";
            string[] stringArray = new string[rows];
            for (int i = 0; i < theString.Length; i++)
            {
                stringArray[tracker] += theString[i];
                if (tracker == 0) adding = true;
                else if (tracker == rows - 1) adding = false;
                if (adding) tracker++;
                else tracker--;
            }
            foreach (string s in stringArray)
            {
                returnString += s;
            }
                return returnString;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetNewString(2, "a"));
            Console.WriteLine("Hello World");
        }
    }
}