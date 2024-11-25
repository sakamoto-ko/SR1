using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotTest
{
    internal class Robot
    {
        //field
        protected string name = "";
        protected bool powerStatus = false;

        //method//コンストラクタ
        public Robot(string name)
        {
            this.name = name;
        }

        //nameの値を返す
        public string GetName()
        {
            return name;
        }

        //攻撃する
        public virtual void Attack()
        {
            Console.WriteLine("{0}は、攻撃した！", name);
        }
    }
}
