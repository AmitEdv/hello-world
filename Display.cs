using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_C16
{
    public class Display
    {
        internal static string askForName()
        {
            Console.WriteLine("Please enter the player's name: ");
            return Console.ReadLine();
        }

        //returns true for Human,false for auto
        internal static bool inputIsHumanPlayer()
        {
            string msg = "Do you play against a human? If so, press Y. Else press N.";
            Console.WriteLine(msg);

            string inputIfHumanPlayer = Console.ReadLine();
            const string yes = "y";
            const string no = "n";

            while ((inputIfHumanPlayer.ToLower() != yes) && (inputIfHumanPlayer.ToLower() != no))
            {
                msgInputError();
                Console.WriteLine(msg);
                inputIfHumanPlayer = Console.ReadLine();
            }

            return (inputIfHumanPlayer.ToLower() == yes);
        }

        internal static void msgInputError()
        {
            Console.WriteLine("Input Error! Try again...");
        }

        internal static void askForBoardSize(out int o_rows, out int o_cols)
        {
            int totalSize = 1;
            string msgEnterSize = "Enter the size of board.\nNote!- The total size of board should be even, and lower than "+Board.m_MaxSizeOfBoard;

            do 
            {
                Console.WriteLine(msgEnterSize);
                Console.WriteLine("Enter number of rows: ");
                while (!int.TryParse(Console.ReadLine(), out o_rows))
                {
                   msgInputError();
                   Console.WriteLine("Enter number of rows: ");

                }

                Console.WriteLine("Enter number of columns: ");
                while (!int.TryParse(Console.ReadLine(), out o_cols))
                {
                    msgInputError();
                    Console.WriteLine("Enter number of cols: ");

                }

                totalSize = o_rows * o_cols; 
            }
            while (totalSize % 2 == 1);
        }

        internal static void printBoard(Board i_Board)
        {
            for (int i = 0; i < (i_Board.Rows * 2); i++)
            {
                for (int j = 0; j < i_Board.Cols; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("====");
                    }
                    else
                    {
                        Console.Write("|   ");
                    }
                }
                Console.Write(System.Environment.NewLine);
            }
        }
    }
}
