using System;
using System.Xml.Schema;

namespace SHVFS_Naomi
{
    public class program
    {
        public static void Main(string[] args)
        {
            //var arithmeticOperatorPulsPuls = 4;
            //arithmeticOperatorPulsPuls++;
            //

            //Console.WriteLine(arithmeticOperatorPulsPuls);
            //Console.ReadLine();

            //for loop
            //First we assign a value to our variable ,and declare one if it needs to be declared
            //Then there is an evaluation/cheak...
            //then, we inrecment/decrement our varlable at the END of the loop


            /*Console.WriteLine("This is BEFORE our FOR LOOP!");

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine("this is THE FIRST LINE in our FOR LOOP!");
                Console.WriteLine($"The value of i is:{i}");
            }

            Console.WriteLine("This is AFTER our FOR LOOP!");
            Console.ReadLine();*/

            //while loop
            //var input = "";

            //while(true) is 
            //
            //while (true)

            /* while (input != "Quit")
             {
                 Console.Clear();
                 // \ Can be 
                 Console.WriteLine($"ENter\"Quit\" to win the game1!");
                 input = Console.ReadLine();
             }
             Console.WriteLine("CONGRATS! YOU WOW!");
             Console.ReadLine();*/

            //do while loo[
            //very similar to while...But
            //IT is NOT TESTED/EVALUATED until the LOOP is run ONCE*/

            //int i;

            // \n gives
            /* Console.WriteLine("Enter 1 for options\n" +
                               "      2 to quit\n" +
                               "      3 to start game");

             do
             {
                 Console.WriteLine("Please make a selection! HAHA!");
                 i = Convert.ToInt32(Console.ReadLine());
             } while (i < 1 || i > 3);

             Console.WriteLine("Excellent Choice!");
             Console.ReadLine();*/

            //Nested for loops...
            //You might work with these for 2d arrays, grids, tules...
            //Outer loop
            /*for (var i = 0; i < 7; i++) 
            {
                for (var j = 0; j < 10; j++) 
                {
                    Console.WriteLine($"i is: {i}, and j is: {j}");
                }
            }

            Console.ReadLine();*/

            //Arrays
            //Arrays start at index ZERO// we'll learn more about this "new" keyword when we do classes
            //Arrays hold STUFF/THINGS,and we set it to a size it to a size of FIVE (it can hold FIVE thinga!)
            //This array holds ints
            /*var scores = new int[7];
            scores[0] = 7;
            scores[1] = 24;
            scores[2] = 2;
            scores[3] = 9;
            scores[4] = 1;
            scores[5] = 234234;
            scores[6] = 99;*/


            //You can also set values for the indices when you declare the array
            //Remeber.computers are dumb, but they know SOME things...
            //we're just making it qu
            //var scores = new int[5] {55,3,24,29,33};
            //var scores = new int[] { 55, 3, 24, 29, 33 };
            //var scores = new[] { 55, 3, 24, 29, 33 };

            //ThIS IS BAD
            //IT USES MAGIC NUMBERS/HARDCODED?INFLEXIBLE/DANGEROUS eg."5"
            /*for (var i = 0; i < scores.Length; i++)
            {
                Console.WriteLine($"The length of scores is: {scores.Length} | The indes is: {scores[i]}");
            }

            Console.ReadLine();*/

            //var scores = new int[5];




        }

    }
}