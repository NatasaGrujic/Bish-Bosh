using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bish_Bosh
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Bish Bosh 1
            /*            Console.Write("Hur lång loop vill du ha?: ");
                        int input1 = int.Parse(Console.ReadLine());

                        Console.Write("Skriv in ett tal (Bish): ");
                        int Bish = int.Parse(Console.ReadLine());

                        Console.Write("Skriv in ett tal (Bosh): ");
                        int Bosh = int.Parse(Console.ReadLine());

                        for (int i = 1; i < input1; i++)
                        {

                            if (i % Bish == 0 && i % Bosh == 0)
                            {
                                Console.WriteLine(i+" Bish:Bosh - ");
                            }

                            else if (i % Bish == 0)
                            {
                                Console.Write(i + "-Bish - ");
                            }

                            else if (i % Bosh == 0)
                            {
                                Console.Write(i + "-Bosh - ");
                            }                   
                            }
                        Console.ReadKey(true);*/
            #endregion

            #region Bish Bosh 2
            /*            Console.Title = "BISH - BOSH";
                        Console.Beep();
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Press Enter-button to start playing BISH - BOSH");
                        Console.ReadLine();
                        Console.Write("Enter a number for loop lengh: ");
                        int loop = int.Parse(Console.ReadLine());
                        Console.Write("Enter BISH no: ");
                        int BISH = int.Parse(Console.ReadLine());
                        Console.Write("Enter BOSH no: ");
                        int BOSH = int.Parse(Console.ReadLine());

                        for (int i = 1; i <= loop; i++)
                        {

                            if (i % BISH == 0 && i % BOSH == 0)
                            {
                                Console.Write(" BISH:BOSH ");
                            }
                            else if (i % BISH == 0)
                            {
                                Console.Write(" BISH ");
                            }
                            else if (i % BOSH == 0)
                            {
                                Console.Write(" BOSH ");
                            }
                            else
                            {
                                Console.Write(" " + i + " ");
                            }

                        }

                        Console.WriteLine("\n\n Press any key to quit");
                        Console.ReadKey(true);
            */
            #endregion

            #region Bish Bosh 3
            Console.Write("Hur lång loop vill du ha?: ");
            int input1 = int.Parse(Console.ReadLine());

            Console.Write("Skriv in ett tal (Bish): ");
            int Bish = int.Parse(Console.ReadLine());

            Console.Write("Skriv in ett tal (Bosh): ");
            int Bosh = int.Parse(Console.ReadLine());

            for (int i = 0; i < input1; i++)
            {

                if (i % Bish == 0 && i % Bosh == 0)
                {
                    Console.Write(" BISH:BOSH ");
                }

                else if (i % Bish == 0)
                {
                    Console.Write(" BISH ");
                }

                else if (i % Bosh == 0)
                {
                    Console.Write(" BOSH ");
                }
                else
                {
                    Console.Write(" " + i + " ");
                }
            }
            Console.ReadKey(true);

            #endregion
        }

    }
}
