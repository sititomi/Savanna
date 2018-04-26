using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Lion
    {
        public int Hp { get; set; }
        public void Attack(Lion lion)
        {
            Hp -= 5;
            lion.Hp -= 5;
            


        }
        public Lion()
        {
            Hp = 20;
        }

        public Lion(int hp)
        {
            Hp = hp;
        }



    }
}
