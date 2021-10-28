using System;
using System.IO;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = true;

            int[] nums = new int[100];
            float m, r;                  // среднее ариф. и разница
            int i, j, k, sum, intM, end;         
            string line;

            end = 0;
            i = 0;
            j = 0;
            sum = 0;



            using (StreamReader sr = new StreamReader(@"C:\Users\crazy.DESKTOP-OUT1PJD\Desktop\nums.txt"))
            {
                while((line = sr.ReadLine()) != null)
                {
                    nums[i] = Convert.ToInt32(line);
                    sum += nums[i];
                    i++;
                }


                m = (float)(Convert.ToDouble(sum) / Convert.ToDouble(i));
                intM = sum / i;
                r = m - intM;
                if (0.5 <= r)
                    intM++;



                
                sr.Close();
            }
            k = i;
            i = 0;
            while (check)        //пока количество равных чисел массива НЕ РАВНО всем числам массива
            {
               

                    if (nums[i] == intM)    //проверка все ли числа массива равны
                    {
                        j++;
                        i++;
                    }
                    else if (nums[i] < intM)
                        nums[i]++;
                    else if (nums[i] > intM)
                        nums[i]--;
                
                if (j == k - 1)
                    check = false;

                end++;
            }
            j = 0;
            while (j <= k)
            {
                j++;
            }
            Console.WriteLine(end);
        }
    }
}
