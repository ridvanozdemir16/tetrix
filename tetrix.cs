using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.SetWindowSize(140,27); //(if you get an error  please delete(/*) */
            //Function for a main menu. (void Entrance()).
            void Entrance()
            {
                //Coloured text with Console.Color command.
               
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                int a;//Created an integer variable for creating game title.
                
                //Console.SetCursorPosition commands for " T " 
                Console.SetCursorPosition(5, 5);
                Console.Write("XXXXXXXXXXXXXXXXXX");
                Console.SetCursorPosition(5, 6);
                Console.Write("XXXXXXXXXXXXXXXXXX");
                for (a = 7; a < 17; a++)
                {
                    Console.SetCursorPosition(12, a);
                    Console.Write("XXXX");

                }
                //Console.SetCursorPosition commands for " E " 
                Console.SetCursorPosition(25, 5);
                Console.Write("XXXXXXXXXXXXXXX");
                Console.SetCursorPosition(25, 6);
                Console.Write("XXXXXXXXXXXXXXX");
                Console.SetCursorPosition(25, 9);
                Console.Write("XXXXXXXXXXXXXXX");
                Console.SetCursorPosition(25, 10);
                Console.Write("XXXXXXXXXXXXXXX");
                Console.SetCursorPosition(25, 15);
                Console.Write("XXXXXXXXXXXXXXX");
                Console.SetCursorPosition(25, 16);
                Console.Write("XXXXXXXXXXXXXXX");
                Console.SetCursorPosition(25, 7);
                Console.Write("XXXX");
                Console.SetCursorPosition(25, 8);
                Console.Write("XXXX");
                Console.SetCursorPosition(25, 9);
                Console.Write("XXXX");

                Console.SetCursorPosition(25, 11);
                Console.Write("XXXX");
                Console.SetCursorPosition(25, 12);
                Console.Write("XXXX");
                Console.SetCursorPosition(25, 13);
                Console.Write("XXXX");
                Console.SetCursorPosition(25, 14);
                Console.Write("XXXX");

                //Console.SetCursorPosition commands for " T " 
                Console.SetCursorPosition(42, 5);
                Console.Write("XXXXXXXXXXXXXXXXXXXX");
                Console.SetCursorPosition(42, 6);
                Console.Write("XXXXXXXXXXXXXXXXXXXX");
                for (a = 7; a < 17; a++)
                {
                    Console.SetCursorPosition(50, a);
                    Console.Write("XXXX");

                }

                //Console.SetCursorPosition commands for " R " 
                for (a = 5; a < 17; a++)
                {
                    Console.SetCursorPosition(64, a);
                    Console.Write("XX");
                }
                Console.SetCursorPosition(66, 5);
                Console.Write("XX");
                Console.SetCursorPosition(68, 6);
                Console.Write("XXX");
                Console.SetCursorPosition(70, 7);
                Console.Write("XXX");
                Console.SetCursorPosition(72, 8);
                Console.Write("XXX");
                Console.SetCursorPosition(74, 9);
                Console.Write("XXX");
                Console.SetCursorPosition(70, 10);
                Console.Write("XXX");
                Console.SetCursorPosition(68, 11);
                Console.Write("XXX");
                Console.SetCursorPosition(66, 12);
                Console.Write("XX");
                Console.SetCursorPosition(66, 13);
                Console.Write("XX");
                Console.SetCursorPosition(68, 14);
                Console.Write("XXX");
                Console.SetCursorPosition(70, 15);
                Console.Write("XXX");
                Console.SetCursorPosition(72, 16);
                Console.Write("XX");

                //Console.SetCursorPosition commands for " I " 
                for (a = 5; a < 17; a++)
                {
                    Console.SetCursorPosition(79, a);
                    Console.Write("XXX");
                }
                //Console.SetCursorPosition commands for " X " 
               
                for (a = 5; a <= 20; a++)
                {

                    Console.SetCursorPosition(82 + a, a - 4);
                    Console.Write("XXXXX");
                    Console.SetCursorPosition(106 - a, a - 4);
                    Console.Write("XXXXX");


                }
                //Game options
                Console.SetCursorPosition(50, 20);
                Console.WriteLine("1. Play Game");
                Console.SetCursorPosition(50, 22);
                Console.WriteLine("2. Highscores");
                Console.SetCursorPosition(50, 24);
                Console.WriteLine("3. Exit");

                //Take Key vairable.
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.KeyChar == '1')
                {
                    Console.Clear();


                }
                else if (info.KeyChar == '2')
                {

                    highscore();//Go to highscore function.

                }

                else if (info.KeyChar == '3')
                {
                    Environment.Exit(1);//Exit the game.

                }
                else
                {
                    Entrance();//Main menu function.
                }

                Console.Clear();
            }
            //Highscore function for the player.
            void highscore()
            {


                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(53, 6);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("HIGH SCORES");
                Console.SetCursorPosition(40, 8); Console.WriteLine("╔═════════════════════════╦═══════╗");
                Console.SetCursorPosition(40, 9); Console.WriteLine("║                         ║       ║");
                Console.SetCursorPosition(40, 10); Console.WriteLine("║                         ║       ║");
                Console.SetCursorPosition(40, 11); Console.WriteLine("║                         ║       ║");
                Console.SetCursorPosition(40, 12); Console.WriteLine("║═════════════════════════╬═══════║");
                Console.SetCursorPosition(40, 13); Console.WriteLine("║                         ║       ║");
                Console.SetCursorPosition(40, 14); Console.WriteLine("║                         ║       ║");
                Console.SetCursorPosition(40, 15); Console.WriteLine("║                         ║       ║");
                Console.SetCursorPosition(40, 16); Console.WriteLine("║═════════════════════════╬═══════║");
                Console.SetCursorPosition(40, 17); Console.WriteLine("║                         ║       ║");
                Console.SetCursorPosition(40, 18); Console.WriteLine("║                         ║       ║");
                Console.SetCursorPosition(40, 19); Console.WriteLine("║                         ║       ║");
                Console.SetCursorPosition(40, 20); Console.WriteLine("║═════════════════════════╬═══════║");
                Console.SetCursorPosition(40, 21); Console.WriteLine("║                         ║       ║");
                Console.SetCursorPosition(40, 22); Console.WriteLine("║                         ║       ║");
                Console.SetCursorPosition(40, 23); Console.WriteLine("║                         ║       ║");
                Console.SetCursorPosition(40, 24); Console.WriteLine("╚═════════════════════════╩═══════╝");

                Console.SetCursorPosition(68, 10);
                Console.WriteLine("TURN");
                Console.SetCursorPosition(52, 10);
                Console.WriteLine("NAME");
                Console.SetCursorPosition(52, 14);
                Console.WriteLine("Eray");
                Console.SetCursorPosition(70, 14);
                Console.WriteLine("7");
                Console.SetCursorPosition(52, 18);
                Console.WriteLine("Rıdvan");
                Console.SetCursorPosition(70, 18);
                Console.WriteLine("13");
                Console.SetCursorPosition(52, 22);
                Console.WriteLine("Hazar");
                Console.SetCursorPosition(70, 22);
                Console.WriteLine("18");

                Console.SetCursorPosition(1, 1);
                Console.WriteLine("<══ (ESC)");
                //Take key info from user to return the main manu.
                ConsoleKeyInfo info1 = Console.ReadKey();
                if (info1.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Entrance();//Return the main menu.
                }

                else
                {
                    highscore();
                }
            }



            Entrance();//Return the main menu.

            //Asking player for tutorial if player don't know how to play the game.
            Console.WriteLine("Do you want to see Tutorial? (Y/N)");
            ConsoleKeyInfo info_2 = Console.ReadKey();
            if (info_2.KeyChar == 'Y' || info_2.KeyChar == 'y')
            {
                //First tutorial page.
                Console.Clear();
                Console.WriteLine("                                                      TUTORIAL");
                Console.WriteLine();
                Console.WriteLine("                                  ╔══════════════════════════════════════════════════╗");
                Console.WriteLine("                                  ║                BOARD & PIECES                    ║");
                Console.WriteLine("                                  ║                                                  ║");
                Console.WriteLine("                                  ║        1     2      3    x                       ║");
                Console.WriteLine("                                  ║     ╔═════╦══════╦═════╗                         ║");
                Console.WriteLine("                                  ║   1 ║     ║      ║     ║                         ║");
                Console.WriteLine("                                  ║     ╠═════╬══════╬═════╣                         ║");
                Console.WriteLine("                                  ║   2 ║     ║      ║     ║                         ║");
                Console.WriteLine("                                  ║     ╠═════╬══════╬═════╣                         ║");
                Console.WriteLine("                                  ║   3 ║     ║      ║     ║                         ║");
                Console.WriteLine("                                  ║     ╚═════╩══════╩═════╝                         ║  ");
                Console.WriteLine("                                  ║   y                                              ║");
                Console.WriteLine("                                  ║                                                  ║");
                Console.WriteLine("                                  ║                    PIECES                        ║");
                Console.WriteLine("                                  ║       x              x            x              ║");
                Console.WriteLine("                                  ║       xx             x            x              ║");
                Console.WriteLine("                                  ║       xxx                         x              ║");
                Console.WriteLine("                                  ║                                                  ║");
                Console.WriteLine("                                  ║    # We have 3*3 board like this                 ║");
                Console.WriteLine("                                  ║    # We have 5 pieces that we have to replace    ║");
                Console.WriteLine("                                  ║ on the board                                     ║");
                Console.WriteLine("                                  ║    # The upside of the board is X COORDINATE,    ║");
                Console.WriteLine("                                  ║ the right side of the board is Y COORDINATE      ║");
                Console.WriteLine("                                  ║                                                  ║");
                Console.WriteLine("                                  ║                                      NEXT--->    ║");
                Console.WriteLine("                                  ╚══════════════════════════════════════════════════╝");

               Console.ReadKey();
                //Second tutorial page.
                Console.Clear();
                Console.WriteLine("                                                      TUTORIAL");
                Console.WriteLine();
                Console.WriteLine("                                  ╔══════════════════════════════════════════════════╗");
                Console.WriteLine("                                  ║                PIECES PLACEMENT                  ║");
                Console.WriteLine("                                  ║                                     TURN 1       ║");
                Console.WriteLine("                                  ║        1     2      3    x                       ║");
                Console.WriteLine("                                  ║     ╔═════╦══════╦═════╗       generated piece   ║");
                Console.WriteLine("                                  ║   1 ║     ║      ║     ║              x          ║");
                Console.WriteLine("                                  ║     ╠═════╬══════╬═════╣              x          ║");
                Console.WriteLine("                                  ║   2 ║     ║      ║     ║                         ║");
                Console.WriteLine("                                  ║     ╠═════╬══════╬═════╣     x coordinate: 1     ║");
                Console.WriteLine("                                  ║   3 ║     ║      ║     ║     y coordinate: 1     ║");
                Console.WriteLine("                                  ║     ╚═════╩══════╩═════╝                         ║  ");
                Console.WriteLine("                                  ║   y                                              ║");
                Console.WriteLine("                                  ║                                     TURN 2       ║");
                Console.WriteLine("                                  ║        1     2      3    x                       ║");
                Console.WriteLine("                                  ║     ╔═════╦══════╦═════╗       generated piece   ║");
                Console.WriteLine("                                  ║   1 ║  x  ║      ║     ║              xx         ║");
                Console.WriteLine("                                  ║     ╠═════╬══════╬═════╣                         ║");
                Console.WriteLine("                                  ║   2 ║  x  ║      ║     ║                         ║");
                Console.WriteLine("                                  ║     ╠═════╬══════╬═════╣     x coordinate: 1     ║");
                Console.WriteLine("                                  ║   3 ║     ║      ║     ║     y coordinate: 2     ║");
                Console.WriteLine("                                  ║     ╚═════╩══════╩═════╝                         ║  ");
                Console.WriteLine("                                  ║   y                                              ║");
                Console.WriteLine("                                  ║                                                  ║");
                Console.WriteLine("                                  ║           !!  PIECE WON'T PLACE !!               ║");
                Console.WriteLine("                                  ║ In this situation, you should place the piece    ║");
                Console.WriteLine("                                  ║ to the (0,0) coordinate.                         ║");
                Console.WriteLine("                                  ║                                                  ║");
                Console.WriteLine("                                  ║                                        NEXT--->  ║");
                Console.WriteLine("                                  ╚══════════════════════════════════════════════════╝");

                Console.ReadKey();
                //Third tutorial page.
                Console.Clear();
                Console.WriteLine("                                                      TUTORIAL");
                Console.WriteLine();
                Console.WriteLine("                                  ╔══════════════════════════════════════════════════╗");
                Console.WriteLine("                                  ║                  SCORING SYSTEM                  ║");
                Console.WriteLine("                                  ║                (HIGH SCORE TABLE)                ║");
                Console.WriteLine("                                  ║                                                  ║");
                Console.WriteLine("                                  ║                                                  ║");
                Console.WriteLine("                                  ║    1-The objective of the game is to fill        ║");
                Console.WriteLine("                                  ║      the board with pieces and they can be       ║");
                Console.WriteLine("                                  ║      by using minimum turn number.               ║");
                Console.WriteLine("                                  ║                                                  ║");
                Console.WriteLine("                                  ║    2-There is a highscore table of the game      ║");
                Console.WriteLine("                                  ║     including only 3 names and scores.           ║  ");
                Console.WriteLine("                                  ║                                                  ║");
                Console.WriteLine("                                  ║      High score table will be shown at the       ║");
                Console.WriteLine("                                  ║      end of the game.                            ║");
                Console.WriteLine("                                  ║                                                  ║");
                Console.WriteLine("                                  ║      ╔═════════════════════════╦═══════╗         ║");
                Console.WriteLine("                                  ║      ║      NAME               ║ TURN  ║         ║");
                Console.WriteLine("                                  ║      ║═════════════════════════╬═══════║         ║");
                Console.WriteLine("                                  ║      ║      ERAY               ║   7   ║         ║");
                Console.WriteLine("                                  ║      ║═════════════════════════╬═══════║         ║");
                Console.WriteLine("                                  ║      ║      RIDVAN             ║   13  ║         ║ ");
                Console.WriteLine("                                  ║      ║═════════════════════════╬═══════║         ║");
                Console.WriteLine("                                  ║      ║      HAZAR              ║   18  ║         ║");
                Console.WriteLine("                                  ║      ╚═════════════════════════╩═══════╝         ║");
                Console.WriteLine("                                  ║  If the player's turn number is less than those  ║");
                Console.WriteLine("                                  ║  which are in the table, program takes player's  ║");
                Console.WriteLine("                                  ║  name and puts it in the table in the correct    ║");
                Console.WriteLine("                                  ║  order.                                          ║");
                Console.WriteLine("                                  ║                                                  ║");
                Console.WriteLine("                                  ║                                       NEXT--->   ║");
                Console.WriteLine("                                  ╚══════════════════════════════════════════════════╝");
                Console.ReadKey();

            }
            //Defining the variables
            int turn = 1; //Turn variable
            int x, y; //Coordinates variables
            int b11 = 0, b12 = 0, b13 = 0, b21 = 0, b22 = 0, b23 = 0, b31 = 0, b32 = 0, b33 = 0;//Variables which will control the board if the boxes filled or empty.


            //Board design
            {
                Console.Clear();

               
                Console.WriteLine("Choose a board colour:");//Options for Game board colour.
                Console.WriteLine("Red : 1");
                Console.WriteLine("Green : 2");
                Console.WriteLine("Blue : 3");
                
                ConsoleKeyInfo colour = Console.ReadKey();

                if (colour.KeyChar == '1')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (colour.KeyChar == '2')
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (colour.KeyChar == '3')
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White; //Default colour.
                }

                Console.Clear();
                
                Console.WriteLine("        1       2       3");
                Console.WriteLine("    ╔═══════╦═══════╦═══════╗");
                Console.WriteLine("    ║       ║       ║       ║");
                Console.WriteLine(" 1  ║       ║       ║       ║");
                Console.WriteLine("    ║       ║       ║       ║");
                Console.WriteLine("    ╠═══════╬═══════╬═══════╣");
                Console.WriteLine("    ║       ║       ║       ║");
                Console.WriteLine(" 2  ║       ║       ║       ║");
                Console.WriteLine("    ║       ║       ║       ║");
                Console.WriteLine("    ╠═══════╬═══════╬═══════╣");
                Console.WriteLine("    ║       ║       ║       ║");
                Console.WriteLine(" 3  ║       ║       ║       ║");
                Console.WriteLine("    ║       ║       ║       ║");
                Console.WriteLine("    ╚═══════╩═══════╩═══════╝");
                
            }




            Random piece = new Random();
            int piece_1 = piece.Next(1, 6);

            do// Main loop (do - while) command for the game
            {
                Console.SetCursorPosition(50, 0);

                Console.WriteLine("   Turn " + turn);

                //Clean a part of the screen for new random pieces with Console.SetCursorPosition().
                Console.SetCursorPosition(50, 3);
                Console.Write("                                 ");
                Console.SetCursorPosition(52, 3);
                Console.Write("                                 ");
                Console.SetCursorPosition(54, 3);
                Console.Write("                                 ");
                Console.SetCursorPosition(50, 4);
                Console.Write("                                 ");
                Console.SetCursorPosition(52, 4);
                Console.Write("                                 ");
                Console.SetCursorPosition(54, 4);
                Console.Write("                                 ");
                Console.SetCursorPosition(50, 5);
                Console.Write("                                 ");
                Console.SetCursorPosition(52, 5);
                Console.Write("                                 ");
                Console.SetCursorPosition(54, 5);
                Console.Write("                                 ");

                //write random pieces

                Console.WriteLine();
                Console.SetCursorPosition(50, 2);
                Console.Write("            ");
                Console.SetCursorPosition(50, 2);
                Console.WriteLine("generated piece:\n");//Printing random piece.
                if (piece_1 == 1)
                {


                    Console.SetCursorPosition(50, 3);
                    Console.WriteLine("x");

                }
                if (piece_1 == 2)
                {

                    Console.SetCursorPosition(50, 3);
                    Console.Write("x ");

                    Console.SetCursorPosition(52, 3);
                    Console.WriteLine("x ");


                }
                if (piece_1 == 3)
                {

                    Console.SetCursorPosition(50, 3);
                    Console.Write("x ");
                    Console.SetCursorPosition(52, 3);
                    Console.Write("x ");
                    Console.SetCursorPosition(54, 3);
                    Console.WriteLine("x ");


                }
                if (piece_1 == 4)
                {

                    Console.SetCursorPosition(50, 3);
                    Console.Write("x ");
                    Console.SetCursorPosition(50, 4);
                    Console.Write("x ");

                }
                if (piece_1 == 5)
                {


                    Console.SetCursorPosition(50, 3);
                    Console.WriteLine("x ");
                    Console.SetCursorPosition(50, 4);
                    Console.WriteLine("x ");
                    Console.SetCursorPosition(50, 5);
                    Console.WriteLine("x ");



                }
                //Clean a part of the screen for asking "x" and "y" corrdiantes from player.

                //Asking for "x" coordinates
                Console.SetCursorPosition(50, 7);
                Console.WriteLine("                        ");
                Console.SetCursorPosition(50, 7);
                Console.Write("x coordinate: ");
                x = Convert.ToInt16(Console.ReadLine());

                //Asking for "y" coordinates
                Console.SetCursorPosition(50, 8);
                Console.WriteLine("                        ");
                Console.SetCursorPosition(50, 8);
                Console.Write("y coordinate: ");
                y = Convert.ToInt16(Console.ReadLine());
                Console.SetCursorPosition(50, 8);
                Console.WriteLine("                        ");

                Console.SetCursorPosition(68, 0);
                Console.WriteLine("                                                ");

                // piece placement conditions.
                switch (piece_1)
                {


                    case 1: //Condition for "X" piece and printing it.



                        if (x == 1 && y == 1 && b11 == 0)
                        {
                            Console.SetCursorPosition(8, 3);
                            Console.Write("X");
                            b11 = 1;
                            turn = turn + 1;//Increase the turn variable in every condition.
                            piece_1 = piece.Next(1, 6);//Create new piece in every condition (except    x and y < 0 or > 3 &&   filled place
                        }
                        else if (x == 2 && y == 1 && b21 == 0)
                        {
                            Console.SetCursorPosition(16, 3);
                            Console.Write("X");
                            b21 = 1;
                            turn = turn + 1;
                            piece_1 = piece.Next(1, 6);
                        }
                        else if (x == 3 && y == 1 && b31 == 0)
                        {
                            Console.SetCursorPosition(24, 3);
                            Console.Write("X");
                            b31 = 1;
                            turn = turn + 1;
                            piece_1 = piece.Next(1, 6);
                        }
                        else if (x == 1 && y == 2 && b12 == 0)
                        {
                            Console.SetCursorPosition(8, 7);
                            Console.Write("X");
                            b12 = 1;
                            turn = turn + 1;
                            piece_1 = piece.Next(1, 6);
                        }
                        else if (x == 2 && y == 2 && b22 == 0)
                        {
                            Console.SetCursorPosition(16, 7);
                            Console.Write("X");
                            b22 = 1;
                            turn = turn + 1;
                            piece_1 = piece.Next(1, 6);
                        }
                        else if (x == 3 && y == 2 && b32 == 0)
                        {
                            Console.SetCursorPosition(24, 7);
                            Console.Write("X");
                            b32 = 1;
                            turn = turn + 1;
                            piece_1 = piece.Next(1, 6);
                        }
                        else if (x == 1 && y == 3 && b13 == 0)
                        {
                            Console.SetCursorPosition(8, 11);
                            Console.Write("X");
                            b13 = 1;
                            turn = turn + 1;
                            piece_1 = piece.Next(1, 6);
                        }
                        else if (x == 2 && y == 3 && b23 == 0)
                        {
                            Console.SetCursorPosition(16, 11);
                            Console.Write("X");
                            b23 = 1;
                            turn = turn + 1;
                            piece_1 = piece.Next(1, 6);
                        }
                        else if (x == 3 && y == 3 && b33 == 0)
                        {
                            Console.SetCursorPosition(24, 11);
                            Console.Write("X");
                            b33 = 1;
                            turn = turn + 1;
                            piece_1 = piece.Next(1, 6);
                        }

                        else if (x == 0 && y == 0)
                        {
                            piece_1 = piece.Next(1, 6);
                            turn = turn + 1;
                        }

                        else
                        {
                            turn = turn + 1;
                            Console.SetCursorPosition(68, 0);
                            Console.WriteLine("Place the piece to an empty place");
                        }

                        break;

                    case 2://Condition for "X X" piece and printing it.


                        if (x == 1 && y == 1 && b11 == 0 && b21 == 0)
                        {
                            Console.SetCursorPosition(8, 3);
                            Console.Write("X");
                            b11 = 1;
                            Console.SetCursorPosition(16, 3);
                            Console.Write("X");
                            b21 = 1;
                            turn = turn + 1;
                            piece_1 = piece.Next(1, 6);
                        }
                        else if (x == 2 && y == 1 && b21 == 0 && b31 == 0)
                        {
                            Console.SetCursorPosition(16, 3);
                            Console.Write("X");
                            b21 = 1;
                            Console.SetCursorPosition(24, 3);
                            Console.Write("X");
                            b31 = 1;
                            turn = turn + 1;
                            piece_1 = piece.Next(1, 6);
                        }
                        else if (x == 1 && y == 2 && b12 == 0 && b22 == 0)
                        {
                            Console.SetCursorPosition(8, 7);
                            Console.Write("X");
                            b12 = 1;
                            Console.SetCursorPosition(16, 7);
                            Console.Write("X");
                            b22 = 1;
                            turn = turn + 1;
                            piece_1 = piece.Next(1, 6);
                        }
                        else if (x == 2 && y == 2 && b22 == 0 && b32 == 0)
                        {
                            Console.SetCursorPosition(16, 7);
                            Console.Write("X");
                            b22 = 1;
                            Console.SetCursorPosition(24, 7);
                            Console.Write("X");
                            b32 = 1;
                            turn = turn + 1;
                            piece_1 = piece.Next(1, 6);
                        }
                        else if (x == 1 && y == 3 && b13 == 0 && b23 == 0)
                        {
                            Console.SetCursorPosition(8, 11);
                            Console.Write("X");
                            b13 = 1;
                            Console.SetCursorPosition(16, 11);
                            Console.Write("X");
                            b23 = 1;
                            turn = turn + 1;
                            piece_1 = piece.Next(1, 6);

                        }
                        else if (x == 2 && y == 3 && b23 == 0 && b33 == 0)
                        {
                            Console.SetCursorPosition(16, 11);
                            Console.Write("X");
                            b23 = 1;
                            Console.SetCursorPosition(24, 11);
                            Console.Write("X");
                            b33 = 1;
                            turn = turn + 1;
                            piece_1 = piece.Next(1, 6);
                        }

                        else if (x == 0 && y == 0)
                        {
                            piece_1 = piece.Next(1, 6);
                            turn = turn + 1;
                        }
                        else
                        {
                            turn = turn + 1;
                            Console.SetCursorPosition(68, 0);
                            Console.WriteLine("Place the piece to an empty place");
                        }


                        break;


                    case 3://Condition for "X X X" piece and printing it.



                        if (x == 1 && y == 1 && b11 == 0 && b21 == 0 && b31 == 0)
                        {
                            Console.SetCursorPosition(8, 3);
                            Console.Write("X");
                            b11 = 1;
                            Console.SetCursorPosition(16, 3);
                            Console.Write("X");
                            b21 = 1;
                            Console.SetCursorPosition(24, 3);
                            Console.Write("X");
                            b31 = 1;
                            turn = turn + 1;
                            piece_1 = piece.Next(1, 6);


                        }


                        else if (x == 1 && y == 2 && b12 == 0 && b22 == 0 && b32 == 0)
                        {
                            Console.SetCursorPosition(8, 7);
                            Console.Write("X");
                            b12 = 1;
                            Console.SetCursorPosition(16, 7);
                            Console.Write("X");
                            b22 = 1;
                            Console.SetCursorPosition(24, 7);
                            Console.Write("X");
                            b32 = 1;
                            turn = turn + 1;
                            piece_1 = piece.Next(1, 6);
                        }

                        else if (x == 1 && y == 3 && b13 == 0 && b23 == 0 && b33 == 0)
                        {
                            Console.SetCursorPosition(8, 11);
                            Console.Write("X");
                            b13 = 1;
                            Console.SetCursorPosition(16, 11);
                            Console.Write("X");
                            b23 = 1;
                            Console.SetCursorPosition(24, 11);
                            Console.Write("X");
                            b33 = 1;
                            turn = turn + 1;
                            piece_1 = piece.Next(1, 6);
                        }

                        else if (x == 0 && y == 0)
                        {
                            piece_1 = piece.Next(1, 6);
                            turn = turn + 1;
                        }
                        else
                        {
                            turn = turn + 1;
                            Console.SetCursorPosition(68, 0);
                            Console.WriteLine("Place the piece to an empty place");
                        }





                        break;




                    case 4://Condition for "X" piece and printing it.
                           //              "X"


                        if (x == 1 && y == 1 && b11 == 0 && b12 == 0)
                        {
                            Console.SetCursorPosition(8, 3);
                            Console.Write("X");
                            b11 = 1;
                            Console.SetCursorPosition(8, 7);
                            Console.Write("X");
                            b12 = 1;
                            turn = turn + 1;
                            piece_1 = piece.Next(1, 6);
                        }
                        else if (x == 2 && y == 1 && b21 == 0 && b22 == 0)
                        {
                            Console.SetCursorPosition(16, 3);
                            Console.Write("X");
                            b21 = 1;
                            Console.SetCursorPosition(16, 7);
                            Console.Write("X");
                            b22 = 1;
                            turn = turn + 1;
                            piece_1 = piece.Next(1, 6);
                        }
                        else if (x == 3 && y == 1 && b31 == 0 && b32 == 0)
                        {
                            Console.SetCursorPosition(24, 3);
                            Console.Write("X");
                            b31 = 1;
                            Console.SetCursorPosition(24, 7);
                            Console.Write("X");
                            b32 = 1;
                            turn = turn + 1;
                            piece_1 = piece.Next(1, 6);
                        }
                        else if (x == 1 && y == 2 && b12 == 0 && b13 == 0)
                        {
                            Console.SetCursorPosition(8, 7);
                            Console.Write("X");
                            b12 = 1;
                            Console.SetCursorPosition(8, 11);
                            Console.Write("X");
                            b13 = 1;
                            turn = turn + 1;
                            piece_1 = piece.Next(1, 6);
                        }
                        else if (x == 2 && y == 2 && b22 == 0 && b23 == 0)
                        {
                            Console.SetCursorPosition(16, 7);
                            Console.Write("X");
                            b22 = 1;
                            Console.SetCursorPosition(16, 11);
                            Console.Write("X");
                            b23 = 1;
                            turn = turn + 1;
                            piece_1 = piece.Next(1, 6);
                        }
                        else if (x == 3 && y == 2 && b32 == 0 && b33 == 0)
                        {
                            Console.SetCursorPosition(24, 7);
                            Console.Write("X");
                            b32 = 1;
                            Console.SetCursorPosition(24, 11);
                            Console.Write("X");
                            b33 = 1;
                            turn = turn + 1;
                            piece_1 = piece.Next(1, 6);
                        }

                        else if (x == 0 && y == 0)
                        {
                            piece_1 = piece.Next(1, 6);
                            turn = turn + 1;
                        }
                        else
                        {
                            turn = turn + 1;
                            Console.SetCursorPosition(68, 0);
                            Console.WriteLine("Place the piece to an empty place");
                        }


                        break;

                    case 5://Condition for "X" piece and printing it.
                           //              "X"
                           //              "X"


                        if (x == 1 && y == 1 && b11 == 0 && b12 == 0 && b13 == 0)
                        {


                            Console.SetCursorPosition(8, 3);
                            Console.Write("X");
                            b11 = 1;
                            Console.SetCursorPosition(8, 7);
                            Console.Write("X");
                            b12 = 1;
                            Console.SetCursorPosition(8, 11);
                            Console.Write("X");
                            b13 = 1;
                            turn = turn + 1;
                            piece_1 = piece.Next(1, 6);


                        }
                        else if (x == 2 && y == 1 && b21 == 0 && b22 == 0 && b23 == 0)
                        {

                            Console.SetCursorPosition(16, 3);
                            Console.Write("X");
                            b21 = 1;
                            Console.SetCursorPosition(16, 7);
                            Console.Write("X");
                            b22 = 1;
                            Console.SetCursorPosition(16, 11);
                            Console.Write("X");
                            b23 = 1;
                            turn = turn + 1;
                            piece_1 = piece.Next(1, 6);
                        }


                        else if (x == 3 && y == 1 && b31 == 0 && b32 == 0 && b33 == 0)
                        {


                            Console.SetCursorPosition(24, 3);
                            Console.Write("X");
                            b31 = 1;
                            Console.SetCursorPosition(24, 7);
                            Console.Write("X");
                            b32 = 1;
                            Console.SetCursorPosition(24, 11);
                            Console.Write("X");
                            b33 = 1;
                            turn = turn + 1;
                            piece_1 = piece.Next(1, 6);



                        }
                        else if (x == 0 && y == 0)
                        {
                            piece_1 = piece.Next(1, 6);
                            turn = turn + 1;
                        }

                        else
                        {
                            turn = turn + 1;
                         
                            Console.SetCursorPosition(68, 0);
                            Console.WriteLine("Place the piece to an empty place");
                        }

                        break;
                    default:

                        turn = turn + 1;


                        break;

                        
                }



                if (x > 3 || x < 0 || y < 0 || y > 3)
                {

                    Console.SetCursorPosition(68, 0);
                    Console.Write("                                        ");
                    Console.SetCursorPosition(68, 0);
                    Console.WriteLine("Enter an integer between 1 and 3");
                }




                //End the main game loop if all boxes on the board are filled.
            } while (b11 == 0 || b12 == 0 || b13 == 0 || b21 == 0 || b22 == 0 || b23 == 0 || b31 == 0 || b32 == 0 || b33 == 0);




            //high score table
            {
                string name; //Define a string variable for player name.
                Console.Clear();
                Console.WriteLine("Your Name: ");
                name = Convert.ToString(Console.ReadLine());
                Console.Clear();

                Console.SetCursorPosition(53, 6);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("HIGHSCORES");

                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.SetCursorPosition(40, 8); Console.WriteLine("╔═════════════════════════╦═══════╗");
                Console.SetCursorPosition(40, 9); Console.WriteLine("║                         ║       ║");
                Console.SetCursorPosition(40, 10); Console.WriteLine("║                         ║       ║");
                Console.SetCursorPosition(40, 11); Console.WriteLine("║                         ║       ║");
                Console.SetCursorPosition(40, 12); Console.WriteLine("║═════════════════════════╬═══════║");
                Console.SetCursorPosition(40, 13); Console.WriteLine("║                         ║       ║");
                Console.SetCursorPosition(40, 14); Console.WriteLine("║                         ║       ║");
                Console.SetCursorPosition(40, 15); Console.WriteLine("║                         ║       ║");
                Console.SetCursorPosition(40, 16); Console.WriteLine("║═════════════════════════╬═══════║");
                Console.SetCursorPosition(40, 17); Console.WriteLine("║                         ║       ║");
                Console.SetCursorPosition(40, 18); Console.WriteLine("║                         ║       ║");
                Console.SetCursorPosition(40, 19); Console.WriteLine("║                         ║       ║");
                Console.SetCursorPosition(40, 20); Console.WriteLine("║═════════════════════════╬═══════║");
                Console.SetCursorPosition(40, 21); Console.WriteLine("║                         ║       ║");
                Console.SetCursorPosition(40, 22); Console.WriteLine("║                         ║       ║");
                Console.SetCursorPosition(40, 23); Console.WriteLine("║                         ║       ║");
                Console.SetCursorPosition(40, 24); Console.WriteLine("╚═════════════════════════╩═══════╝");

                if (turn <= 7)//Condition if player end the game before 7 turn or on 7 turn.Player will be first.
                {
                    Console.SetCursorPosition(68, 10);
                    Console.WriteLine("TURN");
                    Console.SetCursorPosition(52, 10);
                    Console.WriteLine("NAME");
                    Console.SetCursorPosition(52, 14);
                    Console.WriteLine(name);
                    Console.SetCursorPosition(70, 14);
                    Console.WriteLine("{0}", turn);
                    Console.SetCursorPosition(52, 18);
                    Console.WriteLine("Eray");
                    Console.SetCursorPosition(70, 18);
                    Console.WriteLine("7");
                    Console.SetCursorPosition(52, 22);
                    Console.WriteLine("Rıdvan");
                    Console.SetCursorPosition(70, 22);
                    Console.WriteLine("13");
                }

                else if (7 < turn && turn <= 13) //Condition if player end the game before 13 turn or on the 13 turn.Player will be secon.
                {
                    Console.SetCursorPosition(68, 10);
                    Console.WriteLine("TURN");
                    Console.SetCursorPosition(52, 10);
                    Console.WriteLine("NAME");
                    Console.SetCursorPosition(52, 14);
                    Console.WriteLine("Eray");
                    Console.SetCursorPosition(70, 14);
                    Console.WriteLine("7");
                    Console.SetCursorPosition(52, 18);
                    Console.WriteLine(name);
                    Console.SetCursorPosition(70, 18);
                    Console.WriteLine("{0}", turn);
                    Console.SetCursorPosition(52, 22);
                    Console.WriteLine("Rıdvan");
                    Console.SetCursorPosition(70, 22);
                    Console.WriteLine("13");
                }
                else if (13 < turn && turn <= 18) //Condition if player end the game before 18 turn or on 18 turn.Player will be third.
                {
                    Console.SetCursorPosition(68, 10);
                    Console.WriteLine("TURN");
                    Console.SetCursorPosition(52, 10);
                    Console.WriteLine("NAME");
                    Console.SetCursorPosition(52, 14);
                    Console.WriteLine("Eray");
                    Console.SetCursorPosition(70, 14);
                    Console.WriteLine("7");
                    Console.SetCursorPosition(52, 18);
                    Console.WriteLine("Rıdvan");
                    Console.SetCursorPosition(70, 18);
                    Console.WriteLine("13");
                    Console.SetCursorPosition(52, 22);
                    Console.WriteLine(name);
                    Console.SetCursorPosition(70, 22);
                    Console.WriteLine("{0}", turn);
                }

                else //Condition if player can't end the game before 18 turn player will not be on the high score table.
                {
                    Console.SetCursorPosition(68, 10);
                    Console.WriteLine("TURN");
                    Console.SetCursorPosition(52, 10);
                    Console.WriteLine("NAME");
                    Console.SetCursorPosition(52, 14);
                    Console.WriteLine("Eray");
                    Console.SetCursorPosition(70, 14);
                    Console.WriteLine("7");
                    Console.SetCursorPosition(52, 18);
                    Console.WriteLine("Rıdvan");
                    Console.SetCursorPosition(70, 18);
                    Console.WriteLine("13");
                    Console.SetCursorPosition(52, 22);
                    Console.WriteLine("Hazar");
                    Console.SetCursorPosition(70, 22);
                    Console.WriteLine("18");

                }
                //Command for exit the game.
                Console.SetCursorPosition(75, 0);
                Console.WriteLine("Please press any key to exit");
                Console.ReadKey();
            }

        }
    }
}
