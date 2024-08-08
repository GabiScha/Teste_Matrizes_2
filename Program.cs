using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Matriz_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz3 = new int[5, 5];
            int total = 0;

            for (int li = 0; li < 5; li++)
            {

                for (int c = 0; c < 5; c++)
                {

                    matriz3[li, c] = 0;

                }

            }

            for (int li = 0; li < 5; li++)
            {

                for (int c = 0; c < 5; c++)
                {

                    if (li == 0)
                    {


                        if (c == 4)
                        {

                            Console.Write("1");
                            total++;

                        }
                        else
                        {
                            Console.Write("0");
                        }


                    }
                    else if (li == 1)
                    {


                        if (c == 3)
                        {

                            Console.Write("1");
                            total++;

                        }
                        else
                        {
                            Console.Write("0");
                        }
                    }
                    else if (li == 2)
                    {


                        if (c == 2)
                        {

                            Console.Write("1");
                            total++;

                        }
                        else
                        {
                            Console.Write("0");
                        }
                    }
                    else if (li == 3)
                    {


                        if (c == 1)
                        {

                            Console.Write("1");
                            total++;

                        }
                        else
                        {
                            Console.Write("0");
                        }
                    }
                    else if (li == 4)
                    {


                        if (c == 0)
                        {

                            Console.Write("1");
                            total++;

                        }
                        else
                        {
                            Console.Write("0");
                        }
                    }
                    else
                    {
                        Console.Write("0");
                    }
                       
                   


                }
                Console.Write("\n");
            }
            Console.Write(total+"");
            Console.Write("\n");
            Console.Write("---------------------------------");
            Console.Write("\n");
            int[,] matriz33 = new int[3, 3];

            for (int li = 0; li < 3; li++)
            {

                for (int c = 0; c < 3; c++)
                {
                    if (li == 0)
                    {
                        if (c == 0)
                        {
                            matriz3[li, c] = 2;
                        }
                    }
                    else
                    {
                        matriz3[li, c]= 2;
                    }
                }

            }

            for (int li = 0; li < 3; li++)
            {

                for (int c = 0; c < 3; c++)
                {

                    Console.Write(matriz33[li, c] + "");

                }
                Console.Write("\n");
            }









            Console.ReadKey();




        }
    }
}
