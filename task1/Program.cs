using System;

namespace task1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int i, j;
            string NumberFirsts = "1";
            bool check = true;

            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];

            i = 0;
            j = 0;

            while(i!=n)
            {
                i++;
                array[i - 1] = i;
            }
            i = 0;

            i++;
            j++;

            while (check == true)
            {
                if (j == (m-1))
                {
                    if (array[i] == 1)
                        check = false;
                    else
                    {
                        j = 0;
                        NumberFirsts += array[i].ToString();
                    }
                }
                else
                {
                    if (i == (n - 1))
                    {
                        i = 0;
                        j++;
                    }
                    else
                    {
                        i++;
                        j++;
                    }
                }
            }



            Console.WriteLine($"{NumberFirsts}");
            Console.ReadKey();
        }
    }
}
