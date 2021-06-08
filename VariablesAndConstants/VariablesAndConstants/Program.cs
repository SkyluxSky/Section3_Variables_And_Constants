using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**Notes*
 Variable: a name given to a storage location in memory.

 Constant: an immutable value.(Represented by const)
 
 */

namespace VariablesAndConstants
{
    class Program
    {
        const long myLongValue = 1000000000L;
        const byte myByteValue = 250;

        static void Main(string[] args)
        {
            //Example of Variables an Constants.
            int myInteger = 1;
            double myDouble = 3.0;
            const float Pi = 3.14f;
            decimal myDecimal = 16.444m;
            char myCharacter = 'F';
            String myString = "Cam";
            bool myBoolean = true;

            Console.WriteLine(myDouble);
            Console.WriteLine(Pi);
            Console.WriteLine(myString);
            Console.WriteLine(myCharacter);
            
            double sum = myInteger + myDouble +  Pi;
            Console.WriteLine("Sum = " + sum);

            //Console.ReadLine();


            //Overflowing Example
            //Checked - prevents overflows from occurring...
            //Program will crash an throw error - instead of making value 0 again.
            checked 
            {
                short largeByte = 255;
                largeByte += 1; //0
            }

            //Example of VAR variable
            //Really screwy example of C# declaring a string.
            var mySomething = "5c" + true + 33;
            Console.WriteLine(mySomething);

            //Output With Arguments
            //Format String {0} - Represents First Argument, {1} - Represents Second Argument
            Console.WriteLine("\nMin/Max of a Byte:");
            Console.WriteLine("Min: {0} " + "Max: {1}",byte.MinValue, byte.MaxValue);
            Console.WriteLine("Min: {0} " + "Max: {1}", short.MinValue, short.MaxValue);
            Console.WriteLine("Min: {0} " + "Max: {1}", float.MinValue, float.MaxValue);


            //Constants - Cannot Be Changed
            const double gravity = 9.81;
            Console.WriteLine(gravity);

        }
    }
}
