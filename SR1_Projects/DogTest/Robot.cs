using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogTest
{
    internal class Robot
    {
        //field
        protected string name = "";
        protected bool powerStatus = false;

        //method
        //電源ON
        public void PowerOn()
        {
            powerStatus = true;
            Console.WriteLine("{0}は、起動した！！", name);
        }

        //電源Off
        public void PowerOff()
        {
            powerStatus = false;
            Console.WriteLine("{0}は、停止した..", name);
        }

        //名前取得
        public string GetName()
        {
            return name;
        }

        //電源の状態取得
        public bool GetPowerStatus()
        {
            return powerStatus;
        }
    }
}
