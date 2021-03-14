using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace DictionaryHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> liste = new Dictionary<string, int>();
            liste.Add("Ali", 0);
            liste.Add("Gülşah", 1);
            liste.Add("Mucize", 2);
            

            foreach (KeyValuePair<string, int> item in liste)
            {
                Console.WriteLine(item.Key + " : " + item.Value.ToString());
            }
            Console.ReadLine();
            
        }
    }
}
