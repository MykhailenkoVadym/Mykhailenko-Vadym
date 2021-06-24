using System;

namespace lab_11
{
    class Product
    {
        public bool SizesRemoved { get; set; }
        public bool CutOff { get; set; }
        public bool Exiled { get; set; }
        public bool CutThread { get; set; }
        public bool Drilled { get; set; }
        public bool Painted { get; set; }
        public bool Tested { get; set; }
        public bool Packed { get; set; }

        public void showInfo()
        {
            Console.WriteLine($"SizesRemoved - {SizesRemoved}");
            Console.WriteLine($"CutOff - {CutOff}");
            Console.WriteLine($"Exiled - {Exiled}");
            Console.WriteLine($"CutThread - {CutThread}");
            Console.WriteLine($"Drilled - {Drilled}");
            Console.WriteLine($"Painted - {Painted}");
            Console.WriteLine($"Tested - {Tested}");
            Console.WriteLine($"Packed - {Packed}");
        }
    }

}