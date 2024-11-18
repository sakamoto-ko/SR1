using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogTest
{
    internal class TankRobot : Robot
    {//field

        //method
        //コンストラクタ
        public TankRobot(string name)
        {
            this.name = name;
        }

        //キャノン砲を撃つ
        public void ShotCannon()
        {
            if (powerStatus)
            {
                Console.WriteLine("{0}は、キャノン砲を撃った！", name);
            }
            else
            {
                Console.WriteLine("{0}は、電源Offなのでキャノン砲は使えません...", name);
            }
        }
    }
}
