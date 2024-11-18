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
            //そらとぶを墓をテストする
            FlyingRobot flyingRobot = new FlyingRobot("そらとぶロボ");

            Console.WriteLine("名前：{0}", flyingRobot.GetName());
            Console.WriteLine("電源：{0}", flyingRobot.GetPowerStatus());

            flyingRobot.DropBomb();

            flyingRobot.PowerOn();
            flyingRobot.DropBomb();

            flyingRobot.PowerOff();

            //一時停止
            Console.WriteLine("--------");

            //タンクロボをテストする
            TankRobot tankRobot = new TankRobot("タンクロボ");

            Console.WriteLine("名前：{0}", tankRobot.GetName());
            Console.WriteLine("電源：{0}", tankRobot.GetPowerStatus());

            tankRobot.ShotCannon();

            tankRobot.PowerOn();
            tankRobot.ShotCannon();

            tankRobot.PowerOff();

            //一時停止
            Console.WriteLine("--------");

            //TankRobotクラスの実態を大量生産
            TankRobot[] tanks = new TankRobot[5];

            //5体分のインスタンスを作る
            for (int i = 0; i < tanks.Length; i++)
            {
                tanks[i] = new TankRobot("タンクNo." + i);
            }
            for (int i = 0; i < tanks.Length; i++)
            {
                tanks[i].PowerOn();
            }
            foreach(TankRobot tank in tanks)
            {
                tank.ShotCannon();
            }

            //一時停止
            Console.ReadLine();
        }
    }
}
