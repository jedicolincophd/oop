using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            char repeat;

            do
            {
                int num = rnd.Next(1, 4);
                Console.Clear();
                Console.WriteLine("1] Rock");
                Console.Writaper");
                Console.WriteLine("3] Scissors\n");

                Console.Write("Input choice: ");
                int c = int.Parse(Console.ReadLine());

                switch (c)
                {
                    case 1:
                        Console.WriteLine("\nYou chose: Rock");
                        switch (num)
                        {
                            case 1:
                                Console.WriteLine("Computer chose: Rock");
                                Console.ReadKey();
                                Console.WriteLine("\nBoth rock. It's a tie!");
                                break;
                            case 2:
                                Console.WriteLine("Computer chose: Paper");
                                Console.ReadKey();
                                Console.WriteLine("\nPaper beats rock. You lose!");
                                break;
                            case 3:
                                Console.WriteLine("Computer chose: Scissors");
                                Console.ReadKey();
                                Console.WriteLine("\nRock beats scissors. You win!");
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("\nYou chose: Paper");
                        switch (num)
                        {
                            case 1:
                                Console.WriteLine("Computer chose: Rock");
                                Console.ReadKey();
                                Console.WriteLine("\nPaper beats rock. You win!");
                                break;
                            case 2:
                                Console.WriteLine("Computer chose: Paper");
                                Console.ReadKey();
                                Console.WriteLine("\nBoth paper. It's a tie!");
                                break;
                            case 3:
                                Console.WriteLine("Computer chose: Scissors");
                                Console.ReadKey();
                                Console.WriteLine("\nScissors beats paper. You lose!");
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nYou chose: Scissors");
                        switch (num)
                        {
                            case 1:
                                Console.WriteLine("Computer chose: Rock");
                                Console.ReadKey();
                                Console.WriteLine("\nRock beats scissors. You lose!");
                                break;
                            case 2:
                                Console.WriteLine("Computer chose: Paper");
                                Console.ReadKey();
                                Console.WriteLine("\nScissors beats paper. You win!");
                                break;
                            case 3:
                                Console.WriteLine("Computer chose: Scissors");
                                Console.ReadKey();
                                Console.WriteLine("\nBoth scissors. It's a tie!");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                Console.WriteLine("\n\nDo you want to try again? (y/n)");
                repeat = Console.ReadKey().KeyChar;
                repeat = Char.ToLower(repeat);
            } while (repeat != 'n');
        }
    }
}
