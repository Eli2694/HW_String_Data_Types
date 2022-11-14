using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Data_Types_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //***Replace***
            string repStr = "fffxxxZZZZ";
            string repRes = repStr.Replace("f", "z");
            // zzzxxxZZZZ

            // ***Contains***
            string conStr = "hello, can i...";
            string conStr2 = "can";
            bool conRes = conStr.Contains(conStr2);
            //if conStr2 is found in conStr ?
            // bool = true

            //***copyTo***
            //used to copy a specified number of characters from a specified position in this instance
            //to a specified position in an array of Unicode characters
            string copyStr = "San and Moon";
            char[] destinationStr = new char[5];
            copyStr.CopyTo(0, destinationStr, 2,3);
            //destinationStr = ['\0','\0',S,a,n]

            //***Equals***
            string eqlStr = "eli";
            string eqlStr2 = "eLi";

            bool eqlRes = eqlStr.Equals(eqlStr2);
            //bool = false

            //***indexOf***
            string indStr = "gilgur";
            int indexOfChar = indStr.IndexOf('l');
            //int = 2
            int indexOfChar1 = indStr.IndexOf("gur");
            //int = 3
            int indexOfChar2 = indStr.IndexOf("San");
            //int = -1

            //***insert***
            string inseStr = "abra ";
            string retNewInsStr = inseStr.Insert(5, "kadabra");
            //if the original string(inseStr) has 4 character i can't insert in the 5 
            // retNewInsStr = abra kadabra 

            //***PadRight***
            string PadStr = "micky mouse";
            string StrWithPad = PadStr.PadRight(20);
            int len = PadStr.Length; // 11
            int len2 = StrWithPad.Length; // 20 
            // make the string bigger from right

            //***SubString***
            string fullStr = "eating salad";
            string subStr = fullStr.Substring(0, 5);
            //subStr = eatin (5 characters)
            string subStr1 = fullStr.Substring(5, 6);
            //subStr1 = g sala (6 characters)

            //***ToCharArray***
            string cStr = "My phone number is:";
            int cStrLength = cStr.Length;
            char[] cArr = new char[cStrLength];
            cArr = cStr.ToCharArray();
            //cArr = [M,y,'',p,h,o,n,.....,i,s,:]

            //***Split***
            //he String.Split() method splits a string into an array of strings separated by the split delimeters.
            //The split delimiters can be a character or an array of characters or an array of strings.
            string spStr = "Hag Hanoka";
            string[] spArr = spStr.Split(' ');
            //string[] =  array of strings => 0 = "Hag" , 1 = "Hanoka"
            string numberStr = "21,662-3,5 6";
            char[] delimiters = new char[] { ' ', ',', '-' };
            string[] spArr1 = numberStr.Split(delimiters);
            // ["21","662",...]

            //***Trim***
            string tStr = "    I am having fun       ";
            string afterTrimStr = tStr.Trim();
            //afterTrimStr = "I am having fun"

            //***TrimStart***
            string tsStr = "    my hair is shot   ";
            string afterTrimStartStr = tsStr.TrimStart();
            //afterTrimStartStr = "my hair is shot   "

            //***StartWith***
            string swStr = "cool!";
            bool match = swStr.StartsWith("ck");
            //match = false
            bool match1 = swStr.StartsWith("cool");
            //match = true
            bool match2 = swStr.StartsWith("co");
            //match = true
            bool match3 = swStr.StartsWith("yse");
            //match = false
            bool match4 = swStr.StartsWith("c");
            //match = true

            
            




            int a = 1;

        }
    }
}
