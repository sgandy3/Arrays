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



            char[] lastName = {'g','a','n','d','y'};
            
            Console.WriteLine(lastName.Length);

            //Declare and initialize a string array. Using the Length property, 
            //print the second to last element in the array.

            Console.WriteLine(lastName[(lastName.Length) -2]);
        }
    }
}
