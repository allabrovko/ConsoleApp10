using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
        //    *3. Найти сумму четных элементов массива целых чисел.
             
            int[] a = { 11,8,5,2,6,3};
            int sum = 0;
               for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                    sum = sum + a[i];
           


                    
            }
       
Console.Write(sum);


            /*У вас есть доллары. Вы хотите обменять их на гривны. Есть информация о
            стоимости купли-продажи в банках города.В городе N банков. Составьте
           программу, определяющую, какой банк выбрать, чтобы выгодно обменять
            доллары на гривны.*/
            /*
            int[] n = { 25, 29, 27, 28 };
            
            int max = n[0], maxIndex = 0;
            for (int i = 0; i < n.Length; i++)
            {
                if (max < n[i])
                {
                    max = n[i];
                    maxIndex = i;
                }
            }
            PrintArray("Поиск максимального", n, maxIndex: maxIndex);
            
    */


        }

        static void PrintArray(string description, int[] numbers, int? minIndex = null, int? maxIndex = null, bool isMinDouble = false)
        {
            Console.WriteLine(description);
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == minIndex)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (i == maxIndex)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Gray;
                if (isMinDouble && minIndex > i)
                    Console.ForegroundColor = ConsoleColor.White;
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }

    }
}
