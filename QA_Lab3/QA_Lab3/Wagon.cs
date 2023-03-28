using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Lab3
{
    /// <summary>
    /// Абстрактный класс для описания вагонов
    /// </summary>
    abstract class Wagon
    {
        /// <summary>
        /// Серийный номер вагона
        /// </summary>
        protected string serial_number;
        /// <summary>
        /// Количество мест для размещения пассажиров
        /// </summary>
        protected int seats;
        /// <summary>
        /// Цена билета на одно посадочное место
        /// </summary>
        protected double price;
        /// <summary>
        /// Свойство для цены за посадочное место в вагоне
        /// </summary>
        public double Price { get { return price; } set { price = value; } }
        /// <summary>
        /// Проводник 
        /// </summary>
        protected string conductor;

        /// <summary>
        /// Конструктор вагона
        /// </summary>
        /// <param name="serial_number">Серийный номер вагона</param>
        /// <param name="seats">Количество мест для размещения пассажиров</param>
        /// <param name="price">Цена билета на одно посадочное место</param>
        /// <param name="conductor">Проводник</param>
        public Wagon(string serial_number, int seats, double price , string conductor)
        {
            this.serial_number = serial_number;
            this.seats = seats;
            this.price = price;
            this.conductor = conductor;
        }

        /// <summary>
        /// Абстрактная функция для отображения информации о вагоне
        /// </summary>
        public abstract void Display();
    }
}