using System;

namespace Operarors_Thompson_Lillian
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Initialize an integer that multpies two shortegers
            short shortMult = 6 * 45;
            //initialize an shorteger that adds to shortegers 
            short shortAdd = 55 + 66;
            // Prints the maximum and minimum of the two shorteger
             Console.WriteLine($"The max of {shortMult} and {shortAdd} is {Math.Max(shortMult, shortAdd)}. " + 
                 $"The min of the two is {Math.Min(shortMult, shortAdd)}");

            // Initializes boolean to see if shortMult is greater than shortAdd 
            bool isshortGreater = shortMult > shortAdd;
            // Prints if shortMult is than shortAdd
            Console.WriteLine($"{shortMult} is greater than {shortAdd}, {isshortGreater}.");


            // Initialize an longeger that multpies two longegers
            long longMult = 6 * 45;
            //initialize an longeger that adds to longegers 
            long longAdd = 55 + 66;
            // Prints the maximum and minimum of the two longeger
            Console.WriteLine($"The max of {longMult} and {longAdd} is {Math.Max(longMult, longAdd)}. " +
                $"The min of the two is {Math.Min(longMult, longAdd)}");

            // Initializes boolean to see if floatMult is greater than doubleAdd 
            bool isfloatGreater = floatMult > floatAdd;
            // Prdoubles if floatMult is than floatAdd
            Console.WriteLine($"{floatMult} is greater than {floatAdd}, {isfloatGreater}.");

            // Initialize an floateger that multpies two floategers
            float floatMult = 6.5f * 45.24f;
            //initialize an floateger that adds to floategers 
            float floatAdd = 55.35f + 66.15;
            // Prints the maximum and minimum of the two floateger
            Console.WriteLine($"The max of {floatMult} and {floatAdd} is {Math.Max(floatMult, floatAdd)}. " +
                $"The min of the two is {Math.Min(floatMult, floatAdd)}");

            // Initializes boolean to see if doubleMult is greater than doubleAdd 
            bool isdoubleGreater = doubleMult > doubleAdd;
            // Prints if doubleMult is than doubleAdd
            Console.WriteLine($"{doubleMult} is greater than {doubleAdd}, {isdoubleGreater}.");
            
            
            // Initialize an doubleeger that multpies two doubleegers
            double doubleMult = 6 * 45;
            //initialize an doubleeger that adds to doubleegers 
            double doubleAdd = 55 + 66;
            // Prints the maximum and minimum of the two doubleeger
            Console.WriteLine($"The max of {doubleMult} and {doubleAdd} is {Math.Max(doubleMult, doubleAdd)}. " +
                $"The min of the two is {Math.Min(doubleMult, doubleAdd)}");

            // Initializes boolean to see if intMult is greater than intAdd 
            bool isIntGreater = intMult > intAdd;
            // Prints if intMult is than intAdd
            Console.WriteLine($"{intMult} is greater than {intAdd}, {isIntGreater}.");
        }
      


    }
}
