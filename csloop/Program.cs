using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace csloop
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            long start = DateTime.Now.Ticks;
            long count = 0;
            while (start + (10000000) > DateTime.Now.Ticks)
            {
                count++;
            }
            Console.WriteLine(count+"만큼 반복함");
            */

            string[] array = { "사과","배","포도","딸기","바나나"};
            foreach(string item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            //Thread.Sleep(1000);

           /* int x = 1;
            while (x < 50)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 5);
                if (x % 3 == 0)
                {
                    Console.WriteLine("__@");
                }
                else if (x % 3 == 1)
                {
                    Console.WriteLine("_^@");
                }
                else
                {
                    Console.WriteLine("^_@");
                }
                Thread.Sleep(100);
                x++;
            }*/

            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }

             for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    Console.Write("  ");
                }
                for(int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
            //
            while (true)
            {
                Console.Write("숫자를 입력해주세요, 짝수를 입력하면 종료: ");
                int input = int.Parse(Console.ReadLine());
                if (input % 2 == 0)
                {
                    break;
                }
            }

            //

           for(int i = 1; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            //

            string input2 = "Potato Tomato";
            Console.WriteLine(input2.ToUpper());
            Console.WriteLine(input2.ToLower());

            //

            string input3 = "감자 고구마 토마토";
            string[] inputs = input3.Split(new char[] { ' ' });

            foreach(var item in inputs)
            {
                Console.WriteLine(item);
            }

            //

            string input4 = " test     \n";
            Console.WriteLine("::" + input4.Trim() + "::");
            Console.Read();

            //


        }
    }
}
