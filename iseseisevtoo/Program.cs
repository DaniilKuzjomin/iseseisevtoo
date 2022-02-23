using System;

namespace iseseisevtoo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ü 1.В заданном массиве действительных чисел найдите разность между максимальным и минимальным числом.

            
            float [] numbers = new float[5];
            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine("Sisestage {0} number: ", i+1);
                numbers[i] = float.Parse(Console.ReadLine());

            }
            var Max = numbers[0];
            var Min = numbers[0];
            for (int i = 0; i < 10; i++)
            {
                if (numbers[i] < Min) Min = numbers[i];
                if (numbers[i] > Max) Max = numbers[i];
            }
            float a = (Max - Min);
            Console.WriteLine("Minimaalse ja maksimaalse arvu erinevus : {0} ", a);
            

            //Ü 2.В одномерном массиве из K чисел M[] подсчитайте количество элементов, удовлетворяющих условию 0 < M[i] < 125.K, M создаются случайно.


            Random rnd = new Random();
            int[] M = new int[10];
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                M[i] = rnd.Next(-50, 180);
                if (M[i] > 0 && M[i] < 125)
                count++;
            }
            Console.WriteLine("tingimusele vastavate elementide arv : {0}", count);



            //Ü 3.Задача Иосифа.По кругу располагаются п человек. Ведущий считает по кругу, начиная с первого, и выводит(«казнит») m - го человека.Круг смыкается, счет возобновляется со следующего после «казненного»; так продолжается, пока «в живых» останется только один человек. Найти номер оставшегося «в живых» человека.


























            Console.ReadLine();
        }
    }
}
