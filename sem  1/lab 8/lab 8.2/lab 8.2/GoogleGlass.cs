using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_task2
{
    class GoogleGlass : ColorScreenPhone
    {
        public int lenses = 2;

        public override void Call()
        {
            Console.WriteLine("Just say \"Ok, Glass, let's call to Obama \".\n and i will do it");
        }
        public override void RingTone()
        {
            Console.WriteLine(" Sounds through vibrations? cool!!!");
        }
        public override void SurfTheNet()
        {
            Console.WriteLine("Yeah, you have a browser right in front of you!");
        }

    }
}