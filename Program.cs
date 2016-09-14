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

            
            while (true)                                //changed the coding to be an actual loop.9
            
            {
                 
                int userInput = int.Parse(Console.ReadLine());


                if (userInput % 3 != 0)
                {
                    Console.WriteLine(" You Lost! ");                          
                                                                              
                }
                
              else if (userInput % 3 == 0)                                     
                {
                    Console.WriteLine(" You Win");                            
                    break;                                                    
                }
            }      
          }
    }
}
