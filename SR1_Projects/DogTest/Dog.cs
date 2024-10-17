using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogTest
{
    internal class Dog
    {
        //field
        private bool hungryState;

        //method

        //コンストラクタ
        public Dog()
        {
            hungryState = true;
        }

        public void Eat()
        {
            Console.WriteLine("ぱくぱく");
            hungryState = false;
        }

        public void Run()
        {
            Console.WriteLine("わんわんわん");
            hungryState = true;
        }

        public bool IsHungry()
        {
            return hungryState;
        }
    }
}
