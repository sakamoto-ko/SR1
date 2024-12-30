using FlyingRobotTest;
using RobotTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TankRobotTest;

namespace DogTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //乱数生成機のインスタンス
            Random random = new Random(Environment.TickCount);
            //ListコレクションRobots
            List<Robot> robots = new List<Robot>();
            //ランダムの数字を格納
            int num = 0;

            //サイコロを15回振る
            for (int i = 0; i < 15; i++)
            {
                //ランダムの数字を抽選する
                num = random.Next(0, 1 + 1);

                //数字が0ならタンクロボを出す
                if (num == 0)
                {
                    robots.Add(new TankRobot("タンクロボ"));
                }
                else//0じゃなければ空飛ぶロボを出す
                {
                    robots.Add(new FlyingRobot("空飛ぶロボ"));
                }
            }

            //全ての中身を表示
            foreach (Robot robo in robots)
            {
                robot.Attack();
            }

            //一時停止
            Console.ReadLine();
        }
    }
}
