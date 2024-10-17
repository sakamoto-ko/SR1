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
            //Dogクラスのインスタンス hachi を生成する
            Dog hachi = new Dog();
            hachi.Bark();

            //Dogクラスのインスタンス pochi を生成する
            Dog pochi = new Dog();
            pochi.Bark();
            pochi.Run();

            //一時停止
            Console.ReadLine();
        }
    }
}
