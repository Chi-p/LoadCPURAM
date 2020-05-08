using System;
using System.Collections; // Для работы с листами
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Load_CPU_RAM
{
    class ClassRAM
    {
        // Накопительный массив заполняющий память
        private static ArrayList arrayList = new ArrayList();

        // Переменная хранит размер массива под Пул
        private static int arrayList_Count;

        public static ArrayList ArrayList { get => arrayList; set => arrayList = value; }
        public static int ArrayList_Count { get => arrayList_Count; set => arrayList_Count = value; }

        // Положить объект "pattern" в лист.
        public static void FillMemory()
        {
            lock (ArrayList)
            {
                ClassPattern @pattern = new ClassPattern();

                ArrayList.Add(value: @pattern);
            }

            ArrayList_Count = ArrayList.Count; // Посчитали текущий размер листа
        }
    }
}