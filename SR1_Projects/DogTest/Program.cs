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
            Player player = new Player("ロト", 1);

            //課題
            //player.level = 99999;
            //Console.WriteLine("レベル：{0}", player.GetLevel());

            Console.WriteLine("名前：{0}", player.GetName());
            Console.WriteLine("レベル：{0}", player.GetLevel());

            player.Attack();
            player.Deffence();

            player.LevelUp();
            Console.WriteLine("レベル：{0}", player.GetLevel());

            //一時停止
            Console.ReadLine();
        }
    }
}
