using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DogTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //乱数生成機のインスタンス
            Random random = new Random(Environment.TickCount);
            //Listコレクションnumbers
            List<int> numbers = new List<int>();

            //サイコロを10回振る
            for (int i = 0; i < 10; i++)
            {
                //-5～5の範囲の乱数を発生させる
                numbers.Add(random.Next(-5, 5 + 1));
            }

            //全ての中身を表示
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            //一時停止
            Console.ReadLine();
        }
    }
}
