using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bond_James__Tim_Broughton_
{
    class Program
    {
        static void Main(string[] args)
        {

            int userNumber;
            string userInput;

            while (true)
            {
                Console.Write("Please enter a number between 0 and 12: ");


                userInput = Console.ReadLine();

                userNumber = Int32.Parse(userInput);


                if (userNumber > 12 || userNumber < 0)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }

                for (int i = 0; i < 13; i++)
                {
                    Console.WriteLine("{0} X {1} = {2}\n", i, userNumber, (i * userNumber));
                }

            Console.ReadKey();

        }
    }
}
