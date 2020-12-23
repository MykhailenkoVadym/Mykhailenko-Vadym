using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_task2
{
    class ButtonPhone : DiskPhone
    {

        public bool Buttons = true;

        public override void Call()
        {
            Console.WriteLine("you call someone using buttons and radio waves!");
        }

    }
}