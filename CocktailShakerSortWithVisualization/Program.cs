using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CocktailShakerSortWithVisualization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] visualizerSize = { 29, 120 }; // rows and columns of console

            Random rnd = new Random();
            int[] arr = new int[visualizerSize[1]];
            int[] newDispl = new int[visualizerSize[1]];
            int[] curDispl = new int[visualizerSize[1]];
            int temp = 0;

            /*
             * Possible colors:
             * 0 : Reset Color
             * 1 : Blue
             * 2 : Red
             * 3 : Green
             * 4 : Cyan
             * 5 : Dark Blue
             * 6 : Foreground Red
             */

            for (int x = 0; x < arr.Length; x++)
                arr[x] = rnd.Next(visualizerSize[0]) + 1;

            // this line just sets the window size to always display in a 
            // 120 * 30 characters in size
            Console.SetWindowSize(visualizerSize[1], visualizerSize[0] + 1);

            #region Visualizing initial display
            for (int a = visualizerSize[0]; a > 0; a--) // dictate number of rows
            {
                for (int b = 0; b < arr.Length; b++) // dictate number of columns
                {
                    if (arr[b] >= a)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
            }
            Console.Write("To be sorted using Cocktail Shaker sort... Press any key to begin...");
            Console.ReadKey();
            //Console.Clear(); 
            #endregion

            for (int x = 0; x < (arr.Length / 2) + 1; x++)// number of passes
            {
                for (int y = x; y < arr.Length - 1 - x; y++) // left to right motion
                {
                    newDispl[y] = 2;
                    newDispl[y + 1] = 1;

                    #region Highlighting cell to be checked
                    for (int a = 0; a < arr.Length; a++)
                    //for (int a = visualizerSize[0]; a > 0; a--) // dictate number of rows
                    {
                        for (int b = visualizerSize[0]; b > 0; b--)
                        //for (int b = 0; b < arr.Length; b++) // dictate number of columns
                        {
                            if (newDispl[a] != curDispl[a])
                            {
                                Console.SetCursorPosition(a, b - 1);
                                switch (newDispl[a])
                                {
                                    case 0:
                                        Console.ResetColor();
                                        break;
                                    case 1:
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        break;
                                    case 2:
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        break;
                                    case 3:
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        break;
                                    case 4:
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        break;
                                    case 5:
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        break;
                                    case 6:
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        break;
                                }

                                if (arr[a] > visualizerSize[0] - b)
                                    Console.Write("*");
                                else
                                    Console.Write(" ");
                            }
                        }

                        curDispl[a] = newDispl[a];
                        newDispl[a] = 0;
                    }
                    Console.SetCursorPosition(0, 29);
                    Console.Write("Pass {0} : Thinking . . .                                              ", x);
                    //Console.ReadKey();
                    //Thread.Sleep(200);
                    //Console.Clear(); 
                    #endregion

                    if (arr[y] > arr[y + 1])
                    {
                        temp = arr[y];
                        arr[y] = arr[y + 1];
                        arr[y + 1] = temp;
                        newDispl[y] = 1;
                        newDispl[y + 1] = 2;

                        #region Swapping
                        for (int a = 0; a < arr.Length; a++)
                        //for (int a = visualizerSize[0]; a > 0; a--) // dictate number of rows
                        {
                            for (int b = visualizerSize[0]; b > 0; b--)
                            //for (int b = 0; b < arr.Length; b++) // dictate number of columns
                            {
                                if (newDispl[a] != curDispl[a])
                                {
                                    Console.SetCursorPosition(a, b - 1);
                                    switch (newDispl[a])
                                    {
                                        case 0:
                                            Console.ResetColor();
                                            break;
                                        case 1:
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            break;
                                        case 2:
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            break;
                                        case 3:
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            break;
                                        case 4:
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            break;
                                        case 5:
                                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                                            break;
                                        case 6:
                                            Console.BackgroundColor = ConsoleColor.Red;
                                            break;
                                    }

                                    if (arr[a] > visualizerSize[0] - b)
                                        Console.Write("*");
                                    else
                                        Console.Write(" ");
                                }
                            }

                            curDispl[a] = newDispl[a];
                            newDispl[a] = 0;
                        }
                        Console.SetCursorPosition(0, 29);
                        Console.Write("Pass {0} : Swapping . . .                                              ", x);
                        //Console.ReadKey();
                        //Thread.Sleep(200);
                        //Console.Clear(); 
                        #endregion
                    }

                }
                //Console.ReadKey();

                for (int y = arr.Length - 1 - x; y > 0 + x; y--) // right to left motion
                {

                    newDispl[y] = 4;
                    newDispl[y - 1] = 3;

                    #region Highlighting cell to be checked
                    for (int a = 0; a < arr.Length; a++)
                    //for (int a = visualizerSize[0]; a > 0; a--) // dictate number of rows
                    {
                        for (int b = visualizerSize[0]; b > 0; b--)
                        //for (int b = 0; b < arr.Length; b++) // dictate number of columns
                        {
                            if (newDispl[a] != curDispl[a])
                            {
                                Console.SetCursorPosition(a, b - 1);
                                switch (newDispl[a])
                                {
                                    case 0:
                                        Console.ResetColor();
                                        break;
                                    case 1:
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        break;
                                    case 2:
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        break;
                                    case 3:
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        break;
                                    case 4:
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        break;
                                    case 5:
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        break;
                                    case 6:
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        break;
                                }

                                if (arr[a] > visualizerSize[0] - b)
                                    Console.Write("*");
                                else
                                    Console.Write(" ");
                            }
                        }

                        curDispl[a] = newDispl[a];
                        newDispl[a] = 0;
                    }
                    Console.SetCursorPosition(0, 29);
                    Console.Write("Pass {0} : Thinking . . .                                              ", x);
                    //Console.ReadKey();
                    //Thread.Sleep(200);
                    //Console.Clear(); 
                    #endregion

                    if (arr[y] < arr[y - 1])
                    {
                        temp = arr[y];
                        arr[y] = arr[y - 1];
                        arr[y - 1] = temp;
                        newDispl[y] = 3;
                        newDispl[y - 1] = 4;

                        #region Swapping
                        for (int a = 0; a < arr.Length; a++)
                        //for (int a = visualizerSize[0]; a > 0; a--) // dictate number of rows
                        {
                            for (int b = visualizerSize[0]; b > 0; b--)
                            //for (int b = 0; b < arr.Length; b++) // dictate number of columns
                            {
                                if (newDispl[a] != curDispl[a])
                                {
                                    Console.SetCursorPosition(a, b - 1);
                                    switch (newDispl[a])
                                    {
                                        case 0:
                                            Console.ResetColor();
                                            break;
                                        case 1:
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            break;
                                        case 2:
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            break;
                                        case 3:
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            break;
                                        case 4:
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            break;
                                        case 5:
                                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                                            break;
                                        case 6:
                                            Console.BackgroundColor = ConsoleColor.Red;
                                            break;
                                    }

                                    if (arr[a] > visualizerSize[0] - b)
                                        Console.Write("*");
                                    else
                                        Console.Write(" ");
                                }
                            }

                            curDispl[a] = newDispl[a];
                            newDispl[a] = 0;
                        }
                        Console.SetCursorPosition(0, 29);
                        Console.Write("Pass {0} : Swapping . . .                                              ", x);
                        //Console.ReadKey();
                        //Thread.Sleep(200);
                        //Console.Clear(); 
                        #endregion
                    }
                }

            }

            Console.SetCursorPosition(0, 29);
            Console.Write("Done!!!!!!!!!                                              ");
            Console.ReadKey();
        }
    }
}
