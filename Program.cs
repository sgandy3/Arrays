using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayname0916
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare and initialize an array of characters spelling out your last name.
            //Print the length of the array. 

          

            char[] lastName = new char[5];
            lastName[0] = 'g';
            lastName[1] = 'a';
            lastName[2] = 'n';
            lastName[3] = 'd';
            lastName[4] = 'y';

            Console.WriteLine(lastName.Length);

            //Declare and initialize a string array. Using the Length property, 
            //print the second to last element in the array.

            string[] myLastName = new string [5];
            myLastName[0] = "g";
            myLastName[1] = "a";
            myLastName[2] = "n";
            myLastName[3] = "d";
            myLastName[4] = "y";

            Console.WriteLine(myLastName[(myLastName.Length) -2]);
        }
    }
}
