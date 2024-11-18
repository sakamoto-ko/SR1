using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogTest
{
    internal class FlyingRobot : Robot
    {
        //field

        //method
        //コンストラクタ
        public FlyingRobot(string name)
        {
            this.name = name;
        }

        //爆弾を落とす
        public void DropBomb()
        {
            if (powerStatus)
            {
                Console.WriteLine("{0}は、爆弾を落とした！", name);
            }
            else
            {
                Console.WriteLine("{0}は、電源Offなので爆弾投下は使えません...", name);
            }
        }
    }
}
