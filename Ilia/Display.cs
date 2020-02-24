using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ilia
{
    class Display
    {
        /// <summary>
        /// Handles user input and perform verifications.
        /// </summary>
        /// <param name="userInput">user's input</param>
        /// <returns>Number of stars that will be the foundation of the letters. </returns>
        public int UserInput(string userInput)
        {
            bool pass = false;
            int n;

            //  Let the user define N
            Console.WriteLine("Write the number of stars 👎 that you want to showing the " +
                "tickness of the letter M.");

            //  Verify input
            do
            {
                userInput = Console.ReadLine();
                Int32.TryParse(userInput, out n);

                //  Check if INT
                if (!Int32.TryParse(userInput, out n))
                {
                    Console.WriteLine("Please, enter a whole number.");
                }
                //  If the number is higher than 2 and lower than 10000
                else if (!(n > 2 && n < 10000))
                {
                    Console.WriteLine("Could you try with a number lower than 10000 and higher than 2.");
                }
                //  Check if the number is ODD
                else if (n % 2 != 1)
                {
                    Console.WriteLine("Please input an ODD number.");
                }
                else
                {
                    pass = true;
                }
            } while (!pass);    // until all the requirement are fulfilled make the user response


            return n;
        }

        /// <summary>
        /// Display a star.
        /// </summary>
        /// <param name="n">The number of "*" you want listed on 1 line.</param>
        public void StarDisplay(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
        }

        /// <summary>
        /// Display a dash.
        /// </summary>
        /// <param name="n">The number of "-" you want listed on 1 line.</param>
        public void DashDisplay(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("–");
            }
        }


    }
}
