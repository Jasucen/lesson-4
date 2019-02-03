using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson4_Homework1


//не все понял из вебинара, ДЗ делал очень быстро, т.к. нахожусь в командировке
//часть материалов брал с http://www.cyberforum.ru
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray CoolArray = new MyArray(20); //объявляем массив с кол-вом элементов 20
            CoolArray.Print(); //Выводим в консоль все эллементы массива
            Console.WriteLine("Кол-во пар, делящихся на 3 = " + CoolArray.Divide(3)); //здесь подставили число 3 - знаменатель для подсчета количества пар

            Console.ReadKey();
        }

    }
    
    class MyArray
    {
        int[] a;
        Random r = new Random();

        // Создаем целочисленный массив со случайными значениями от -10000 до 10000 и количеством элементов в массиве n
        public MyArray(int n)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = r.Next(-10000, 10000); //числа, в промежутке которых берутся значения для элементов массива рандомным образом
        }

        
        // Выводим на консоль все элементы массива в одной строке, не совсем понимаю, как это работает, взял пример из вебинара
        //магия, не трогать!
        
        public void Print()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine();
        }

        
        //задаем метод, который выводит количество пар элементов массива, делящихся на n без остатка
        
        public int Divide(int n)
        {
            int x = 0;
            for (int i = 0; i < (a.Length - 1); i++)
            {
                if ((a[i] % n == 0) || (a[i + 1] % n == 0))
                {
                    x++;
                }
            }
            return x;
        }


    }
}



