using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Fuel required to launch a given module is based on its mass. 
 Specifically, to find the fuel required for a module, take its mass, divide by three, 
 round down, and subtract 2.

For example:
For a mass of 12, divide by 3 and round down to get 4, then subtract 2 to get 2.
For a mass of 14, dividing by 3 and rounding down still yields 4, so the fuel required is also 2.
For a mass of 1969, the fuel required is 654.
For a mass of 100756, the fuel required is 33583.
The Fuel Counter-Upper needs to know the total fuel requirement. To find it, individually calculate the fuel needed for the mass of each module (your puzzle input), then add together all the fuel values.  
  

What is the sum of the fuel requirements for all of the modules on your spacecraft?
  */
namespace AdventOfCode.AdventOfCodeDay1
{
    public class AdventOfCode1
    {
        private List<int> StoreAllValues;
        public AdventOfCode1()
        {
            AdventOfCode.FileReader.TextHandler Txthandler = new AdventOfCode.FileReader.TextHandler();
            StoreAllValues = Txthandler.ReadInputFileToListInt("../../ADventOfCodeDay1/Input.txt");
            int maxsize = CalculateTotalFuelRequiermentsPart2();

            Console.WriteLine("the total fuel needed is: " + maxsize);
        }

        private int CalculateTotalFuelRequirments()
        {
            int maxSize = 0;
            for(int i = 0;i<StoreAllValues.Count();i++)
            {
                StoreAllValues[i] /= 3;
                StoreAllValues[i] -= 2;
                maxSize += StoreAllValues[i];
            }
            return maxSize;
        }

        private int CalculateTotalFuelRequiermentsPart2()
        {
            int maxSize = 0;
            for (int i = 0; i < StoreAllValues.Count(); i++)
            {
                while(StoreAllValues[i]>=0)
                { 
                    StoreAllValues[i] /= 3;
                    StoreAllValues[i] -= 2;
                    if(StoreAllValues[i]>=0)
                        maxSize += StoreAllValues[i];
                }
            }
            return maxSize;
        }


    }


}
