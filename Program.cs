using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_9._13_loop
{
    class Program
    {
        static void Main(string[] args)
        {

            //bool executeLoop = true;  The boolean is not needed
            int userInput = int.Parse(Console.ReadLine());
            //executeLoop = userInput % 3 != 0;

            // while userInput is NOT divisible by 3, the loop will continue.
            while (userInput % 3 != 0)                      //condition
            {
                Console.WriteLine(" You Lost! ");           //met condition and writing you lost
                userInput = int.Parse(Console.ReadLine());  // gets user input and starts with the condition
            }

            if (userInput % 3 == 0)                         // unless the userInput IS divisible by three.. 
            {
                Console.WriteLine(" You Win");              // prints this line. No other commands after.
                                                            // since there is no userInput, it won't create a loop (guessing)
            }
                    
          }
    }
}
