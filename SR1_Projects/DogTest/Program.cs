using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dogクラスのインスタンス pochi を生成する
            Dog pochi = new Dog();
            //最初の空腹状態
            Console.WriteLine("空腹状態 : {0}", pochi.IsHungry());
            //ポチに餌を与える
            pochi.Eat();
            Console.WriteLine("空腹状態 : {0}", pochi.IsHungry());
            //ポチを走らせる
            pochi.Run();
            Console.WriteLine("空腹状態 : {0}", pochi.IsHungry());

            //一時停止
            Console.ReadLine();
        }
    }
}
