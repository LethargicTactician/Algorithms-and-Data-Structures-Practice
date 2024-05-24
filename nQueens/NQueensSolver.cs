using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace nQueens
{
    public static class NQueensSolver
    {
        //Im guessing calculateNQueens method is a helper method so Im gonna use this to return the solver recursively
        public static int CalculateNQueens(int n)
        {
            //new queen based on user input num
            int[] positions = new int[n];
            return SolveNQueens(positions, 0);
            
        }
        //pront out the row that the queens end up on when you find a solution
        //for example: if queens end up in the rows  0,1 1,3 2,0 & 3,2 then it will return the rows which are 1,3,0,2

        //return # of solutions so you'll need to know the posion of the queens and return only the row

        //Hint: Define the positions array to store the positions of the queens.
        //Hint: Call the SolveNQueensHelper function with the positions array and the current row number(which will initially be 0).
        private static int SolveNQueens(int[] position, int row)
        {
            //initialize n or whatever were using to keep track of the solutions
            int n = position.Length;
           
            if(row == n)
            {
                //this is just to keeep track of the solution if there is one then increase the count 
                PrintMySolution(position);
                return 1;
            }
            int count = 0;
            //queen is moving per col
            for (int col = 0; col < n; col++)
            {
                //so if we find a safe place then you record the count
                if(IsSafe(position, row, col))
                {
                    position[row] = col;
                    //then check if the next row is valid
                    count += SolveNQueens(position, row + 1);
                }
            }


            //Return the total number of solutions found by the SolveNQueensHelper function.
            return count;
        }

        //I think this class is to mkae sure the position is valid so I obvoisly have to iterate thorugh every row and col along with the positions of the queens
        private static bool IsSafe(int[] position, int row, int column) //think about params (up to you) -> using row, col & position to keep track of the checks for each queen(position)
        {
            //checking each row
            for(int i = 0; i < row; i++)
            {
                //getting absolute value of the queens position so that I can determine the check
                int diff = Math.Abs(position[i] - column ); //difference between the current col position and the col itself(we're looking for a queen here)
                //diagonal check -> if diff is = 0 or rhe row - i then we're not safe (aka it found a queen)
                if(diff == 0 || diff == row - i)
                {
                    return false;
                }
            }
            //else
            return true;
        }


        //got this ide from someone! this is just so that it can display the result as a table 
        //kinf of like what was on the requirements page (I also wanted it to look pretty)
        static void PrintMySolution(int[] QueenPosition)
        {
            int n = QueenPosition.Length;
            Console.WriteLine("Found solution in {0} steps:", n);
            for (int i = 0; i < n; i++)
            {
                //to number the rows
                Console.ForegroundColor= ConsoleColor.Green;
                Console.Write(" {0} ", i);
                Console.ResetColor();
                for(int f = 0; f < n; f++)
                {
                    if (QueenPosition[i] == f)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" Q ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" - ");
                        Console.ResetColor();
                    }
                }
                //whitespace
                Console.WriteLine();    
            }
            //more whitespace so that it looks pretty
            Console.WriteLine();
        }
    }
}
