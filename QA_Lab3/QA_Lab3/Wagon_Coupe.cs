using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Lab3
{
    /// <summary>
    /// Вагон купе, наследуемый от абстрактоного для описания вагонов
    /// </summary>
    class Wagon_Coupe : Wagon
    {
        /// <summary>
        /// Конструктор Вагона купе
        /// </summary>
        /// <param name="serial_number">Серийный номер вагона купе</param>
        /// <param name="seats">Количество мест для размещения пассажиров</param>
        /// <param name="price">Цена за место в вагоне купе</param>
        /// <param name="conductor">Проводник в вагоне купе</param>
        public Wagon_Coupe(string serial_number, int seats, double price, string conductor) : base(serial_number, seats, price, conductor)
        {
            
        }

        /// <summary>
        /// Вывод информации о вагоне купе
        /// </summary>
        public override void Display()
        {
            Console.WriteLine("--------Информация о вагоне-купе.--------");
            Console.WriteLine("Серийный номер вагона: " + serial_number);
            Console.WriteLine("Количество мест в вагоне: " + seats);
            Console.WriteLine("Цена за место (в рублях): " + price);
            Console.WriteLine("Проводник: "  + conductor);
        }
    }
}