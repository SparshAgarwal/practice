using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;


class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        if(n==0)
        {
            Console.WriteLine("0"); // if no temperatures passed then output zero
        }
        else // some values passed, parse andd find the closest to 0
        {
            string temps = Console.ReadLine(); // the n temperatures expressed as integers ranging from -273 to 5526
            string[] temp= temps.Split(' '); // convert into an array of string using space as delimiter
            List<int> tempint = new List<int>(); // list of integers to store temperatures
            foreach(var t in temp)
            {
                tempint.Add(int.Parse(t)); // parse temperatures into list
            }
            int closest = tempint[0]; //dummy to store closest value to 0
            for(int i = 1; i< tempint.Count; i++) // iterating over list
            {
                if(Math.Pow(closest,2)>Math.Pow(tempint[i],2)) //using variance to check which temperature is closest to zero
                { 
                    closest = tempint[i];
                }
                else if(Math.Pow(closest,2)==Math.Pow(tempint[i],2)) //if two variances same, check for positive temperature
                {
                    if(closest<tempint[i])
                    {
                        closest = tempint[i];
                    }
                }
            }
            Console.WriteLine(closest); // print the temperature closest to zero  
        } // end of else block
    } //end of main function
} // end of class
