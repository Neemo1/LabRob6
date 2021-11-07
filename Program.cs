using System;

namespace LabRob6
{
    class Program
    {
        static void Main(string[] args)
        {
            int j;
            int sum = 0;
            string k;
            string strValue;
            int[] iArray1 = new int[10];
            int[] iArray2 = new int[10];
            for (j = 0; j < 10; j++)
            {
                strValue = Console.ReadLine();
                iArray1[j] = Convert.ToInt32(strValue);

            }

            for (j = 0; j < 10; j++) {
                iArray2[j] = iArray1[j];
                if (iArray2[j] < 0)
                {
                    iArray2[j] = iArray2[j] * (0 - 1);
                   
                }

                sum += iArray2[j];
            }
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("\n" + j + "    " + iArray1[j]);

            }
            Console.WriteLine("\n Сумма = " + sum + " Среднее = " + sum / 10d);
        }
    }
}
