using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ilia
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            int n;
            int dashGrowth;
            int starGrowth;
            int dashD = 1;
            int underH = 1;

            //  In order to call my methods.
            Display myDisplay = new Display();

            //  Handle user input.
            n = myDisplay.UserInput(userInput);

            //  Use the number to calculate the growth of the dashes and stars.
            dashGrowth = n;
            starGrowth = n;

            int y = n + 1; //   height of the picture (rows)

            // The point when we will start constructing the next part of the letter (UPPER + LOWER part)
            int changePoint = y / 2;

            //  int x = n * 10; //

            for (int i = 0; i < y; i++)
            {
                if (i >= changePoint)
                {
                    //  LOWER SIDE

                    //  Letter 1.
                    myDisplay.DashDisplay(dashGrowth);
                    myDisplay.StarDisplay(n);
                    myDisplay.DashDisplay(dashD);
                    if (dashD == n)
                    {
                        //  For the last row of the image
                        myDisplay.StarDisplay(n);
                    }
                    else
                    {
                        //  Until we reach the last row of the image calculate the number of stars we need to use.
                        myDisplay.StarDisplay(n * 2 - underH);
                    }
                    myDisplay.DashDisplay(dashD);
                    myDisplay.StarDisplay(n);

                    // Divider between our 2 letters.
                    myDisplay.DashDisplay(n - dashD);

                    //  Letter 2
                    myDisplay.StarDisplay(n);
                    myDisplay.DashDisplay(dashD);
                    if (dashD == n)
                    {
                        myDisplay.StarDisplay(n);
                    }
                    else
                    {
                        myDisplay.
                            StarDisplay((n * 2 - underH));
                    }
                    myDisplay.DashDisplay(dashD);
                    myDisplay.StarDisplay(n);
                    myDisplay.DashDisplay(dashGrowth);
                    Console.WriteLine();

                    //  Calculate
                    underH += 2;
                    starGrowth += 2;
                    dashD = dashD + 2;
                    if (dashGrowth != 0) dashGrowth -= 1;

                }
                else
                {
                    //  UPPER SIDE

                    //  Letter 1
                    myDisplay.DashDisplay(dashGrowth);
                    myDisplay.StarDisplay(starGrowth);
                    myDisplay.DashDisplay(dashGrowth - i);
                    myDisplay.StarDisplay(starGrowth);

                    // Divider between our 2 letters.
                    myDisplay.DashDisplay(dashGrowth);
                    myDisplay.DashDisplay(dashGrowth);

                    // Letter 2.
                    myDisplay.StarDisplay(starGrowth);
                    myDisplay.DashDisplay(dashGrowth - i);
                    myDisplay.StarDisplay(starGrowth);
                    myDisplay.DashDisplay(dashGrowth);
                    Console.WriteLine();

                    //  Calculate
                    starGrowth += 2;
                    dashGrowth -= 1;
                }
            }





            //  Pause program
            Console.ReadLine();

        }
    }
}
