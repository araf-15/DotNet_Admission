using System;

namespace Problem_2
{
    public static class StringExtention
    {
        public static string ToPascel(this string str)
        {
            //char[] charecters = str.ToCharArray();
            //char[] newChar = new char[charecters.Length];

            //for (int i=0; i<charecters.Length; i++)
            //{
            //    if (charecters[i] == ' ')
            //    {
            //        i++;
            //    }
            //    newChar[i] = charecters[i]; 
            //}

            //string str1 = new string(newChar);
            string retString =  string.Join("", str.Split(' '));
            return retString;
        }
    }
}