﻿using System.IO;
using AssemblyBrowserLib;

namespace TestClass
{
    internal static class Program
    {
        private static readonly AssemblyBrowser Browser = new AssemblyBrowser();
        
        public static void Main(string[] args)
        {
            
        }
        
    }
    
    public static class StringExtension
    {
        public static int CharCount(this string str, char c)
        {
            int counter = 0;
            for (int i = 0; i<str.Length; i++)
            {
                if (str[i] == c)
                    counter++;
            }
            return counter;
        }
    }
}