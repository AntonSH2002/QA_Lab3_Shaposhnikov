using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace QA_Lab3
{
    /// <summary>
    /// Класс плацкартного вагона
    /// </summary>
    class Econom_Wagon : Wagon
    {
        /// <summary>
        /// Конструктор плацкартного вагона
        /// </summary>
        /// <param name="serial_number">Серийный номер вагона купе</param>
        /// <param name="seats">Количество мест для размещения пассажиров</param>
        /// <param name="price">Цена за место в вагоне купе</param>
        /// <param name="conductor">Проводник в вагоне купе</param>
        public Econom_Wagon(string serial_number, int seats, double price, string conductor) : base(serial_number, seats, price, conductor)
        {
            
        }

        /// <summary>
        /// Вывод информации о плацкартном вагоне
        /// </summary>
        public override void Display()
        {
            Console.WriteLine("--------Информация о плацкартном вагоне.--------");
            Console.WriteLine("Серийный номер: " + serial_number);
            Console.WriteLine("Количество мест: " + seats);
            Console.WriteLine("Проводник: " + conductor);
        }
    }
}