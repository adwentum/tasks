using System;
using System.IO;
using System.Collections.Generic;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] cord = new int[2][];
            cord[0] = new int[100];
            cord[1] = new int[100];

            int i;
            float CircleX, CircleY, DotX, DotY, H, CircleR;


            i = 0;

            using (StreamReader CircleFile = new StreamReader(@"C:\Users\crazy.DESKTOP-OUT1PJD\Desktop\файл1.txt"))
            {

                string line = CircleFile.ReadLine();
                string x, y, R;
                x = "";
                y = "";
                R = "";


                while ((line[i] != ' '))      //ввод от одного- до много-значного числа
                {
                    x += line[i];
                    i++;
                }
                while ((line[i] == ' '))    //пропуск пустых мест между координатами центра круга
                    i++;
                while ((line.Length-1 >= i))        //ввод от одного- до много-значного числа
                {
                    y += line[i];
                    i++;
                }
                i = 0;

                line = CircleFile.ReadLine();
                while ((CircleFile.Peek() > -1) || (R == ""))       //ввод от одного- до много-значного числа
                {
                    R += line[i];
                    i++;
                }
                i = 0;

                CircleX = Convert.ToInt32(x.ToString());
                CircleY = Convert.ToInt32(y.ToString());
                CircleR = Convert.ToInt32(R.ToString());

                CircleFile.Close();
            }

            using (StreamReader DotFile = new StreamReader(@"C:\Users\crazy.DESKTOP-OUT1PJD\Desktop\файл2.txt"))
            {
                int j = 0;
                string line;
                string x, y;
                x = "";
                y = "";

                while ((line = DotFile.ReadLine()) != null)
                {
                    
                    while ((line[i] != ' '))      //ввод от одного- до много-значного числа
                    {
                        x += line[i];
                        i++;
                    }
                    while ((line[i] == ' '))    //пропуск пустых мест между координатами центра круга
                        i++;
                    while ((line.Length - 1 >= i))        //ввод от одного- до много-значного числа
                    {
                        y += line[i];
                        i++;
                    }

                    cord[0][j] = Convert.ToInt32(x.ToString());
                    cord[1][j] = Convert.ToInt32(y.ToString());

                    j++;
                    i = 0;
                    x = "";
                    y = "";
                }
                int je = j;
                j = 0;
                DotFile.Close();

                while(j < je)
                {
                    DotX = cord[0][j];
                    DotY = cord[1][j];
                    if ((DotX >= CircleX) & (DotY <= CircleY))        //1 четверть
                    {
                        H = (float)(Math.Sqrt((DotX - CircleX) * (DotX - CircleX) + (CircleY - DotY) * (CircleY - DotY)));
                        if (H == CircleR)
                            Console.WriteLine("0");
                        else if (H < CircleR)
                            Console.WriteLine("1");
                        else if (H > CircleR)
                            Console.WriteLine("2");
                    }
                    else if ((DotX <= CircleX) & (DotY <= CircleY))        //2 четверть
                    {
                        H = (float)(Math.Sqrt((CircleX - DotX) * (CircleX - DotX) + (CircleY - DotY) * (CircleY - DotY)));
                        if (H == CircleR)
                            Console.WriteLine("0");
                        else if (H < CircleR)
                            Console.WriteLine("1");
                        else if (H > CircleR)
                            Console.WriteLine("2");
                    }
                    else if ((DotX <= CircleX) & (DotY >= CircleY))        //3 четверть
                    {
                        H = (float)(Math.Sqrt((CircleX - DotX) * (CircleX - DotX) + (DotY - CircleY) * (DotY - CircleY)));
                        if (H == CircleR)
                            Console.WriteLine("0");
                        else if (H < CircleR)
                            Console.WriteLine("1");
                        else if (H > CircleR)
                            Console.WriteLine("2");
                    }
                    else if ((DotX >= CircleX) & (DotY >= CircleY))        //4 четверть
                    {
                        H = (float)(Math.Sqrt((DotX - CircleX) * (DotX - CircleX) + (DotY - CircleY) * (DotY - CircleY)));
                        if (H == CircleR)
                            Console.WriteLine("0");
                        else if (H < CircleR)
                            Console.WriteLine("1");
                        else if (H > CircleR)
                            Console.WriteLine("2");
                    }
                    j++;
                }
            }

        }
    }
}
