using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaBabaTiSmetaloto
{
    class NaBabaTiSmetaloto
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());


            long[,] smetalo = new long[8, width];

            for (int row = 0; row < 8; row++)
            {
                long num = long.Parse(Console.ReadLine());
                string numToString = Convert.ToString(num, 2).PadLeft(width, '0');

                for (int col = 0; col < width; col++)
                {

                    smetalo[row, col] = long.Parse(numToString[col].ToString());
                }

            }


            //Print check of smetalo
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    Console.Write(smetalo[row, col]);
                }
                Console.WriteLine();
            }


            string command = Console.ReadLine();


            bool stopper = true;


            while (stopper == true)
            {



                switch (command)
                {

                    case "right":
                        {
                            int rowR = int.Parse(Console.ReadLine());
                            int posR = int.Parse(Console.ReadLine());
                            if (posR < 0)
                            {
                                posR = 0;
                            }
                            if (posR > width - 1)
                            {
                                posR = width - 1;
                            }


                            long rightCounter = 0;

                            for (int col = posR; col < width; col++)
                            {
                                if (smetalo[rowR, col] == 1)
                                {
                                    smetalo[rowR, col] = 0;
                                    rightCounter++;
                                }
                            }

                            for (int col = width - 1; col > width - 1 - rightCounter; col--)
                            {
                                smetalo[rowR, col] = 1;
                            }

                            command = Console.ReadLine();
                            //stopper = false;

                            break;
                        }
                    case "left":
                        {
                            int rowL = int.Parse(Console.ReadLine());
                            int posL = int.Parse(Console.ReadLine());

                            if (posL < 0)
                            {
                                posL = 0;
                            }
                            if (posL > width - 1)
                            {
                                posL = width - 1;
                            }


                            long leftCounter = 0;

                            for (int col = 0; col <= posL; col++)
                            {
                                if (smetalo[rowL, col] == 1)
                                {
                                    smetalo[rowL, col] = 0;
                                    leftCounter++;
                                }
                            }

                            for (int col = 0; col < leftCounter; col++)
                            {
                                smetalo[rowL, col] = 1;
                            }
                            command = Console.ReadLine();
                            break;

                        }

                    case "reset":
                        {
                            for (int row = 0; row < 8; row++)
                            {

                                long colCounter = 0;

                                for (int col = 0; col < width; col++)
                                {
                                    if (smetalo[row, col] == 1)
                                    {
                                        smetalo[row, col] = 0;
                                        colCounter++;
                                    }

                                }

                                for (int col = 0; col < colCounter; col++)
                                {
                                    smetalo[row, col] = 1;
                                }
                            }

                            command = Console.ReadLine();
                            break;

                        }

                    case "stop":
                        stopper = false;
                        break;


                    default:
                        command = Console.ReadLine();
                        break;
                }

            }

            //Print check of smetalo
            //for (int row = 0; row < 8; row++)
            //{
            //    for (int col = 0; col < width; col++)
            //    {
            //        Console.Write(smetalo[row, col] + "  ");
            //    }
            //    Console.WriteLine();
            //}

            long result = 0;
            for (int row = 0; row < 8; row++)
            {

                StringBuilder sb = new StringBuilder();
                for (int col = 0; col < width; col++)
                {
                    sb.Append(smetalo[row, col]);
                }

                long currNum = Convert.ToInt64(sb.ToString(), 2);
                //Console.WriteLine(currNum);
                result = result + currNum;

            }

            //Console.WriteLine(result);


            long emptyCounter = 0;

            for (int col = 0; col < width; col++)
            {

                bool isEmptiCol = true;

                for (int row = 0; row < 8; row++)
                {
                    if (smetalo[row, col] == 1)
                    {
                        isEmptiCol = false;
                    }
                }
                if (isEmptiCol == true)
                {
                    emptyCounter++;
                }


            }
            Console.WriteLine(emptyCounter * result);
                    }
    }
}
