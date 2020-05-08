using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Load_CPU_RAM
{
    internal class ClassPattern
    {
        private static readonly Random random = new Random(DateTime.Now.Millisecond); // генератор случайных чисел

        static int multiplier = Convert.ToInt32(MainForm.Multiplier);
        static int length = Multiplier * 8 * 1024 * 1024 / 24;


        private readonly int[] FillPattern = new int[Length];



        public ClassPattern()
        {
           

            for (int i = 0; i < Length; i++)
            {
                FillPattern[i] = (int)random.Next(minValue: 0, maxValue: 2);
            }
        }

        public static Random Random => random;

        public static int Multiplier { get => multiplier; set => multiplier = value; }
        public static int Length { get => length; set => length = value; }

        public int[] FillPattern1 => FillPattern;
    }
}
