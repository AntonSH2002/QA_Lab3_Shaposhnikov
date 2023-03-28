using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Lab3
{
    /// <summary>
    /// Класс поезда
    /// </summary>
    class Train
    {
        /// <summary>
        /// Массив вагонов купе
        /// </summary>
        private Wagon_Coupe[] wagon_coupe;
        /// <summary>
        /// Массив плацкартных вагонов
        /// </summary>
        private Econom_Wagon[] econom_wagon;
        /// <summary>
        /// Машинист
        /// </summary>
        private string machinist;
        /// <summary>
        /// Направление
        /// </summary>
        private string route;
        /// <summary>
        /// Количество вагонов купе
        /// </summary>
        private int quantity_coupe;
        /// <summary>
        /// Количество плацкартных вагонов
        /// </summary>
        private int quantity_econom;
        /// <summary>
        /// Дата отбытия поезда
        /// </summary>
        public DateTime date1;
        /// <summary>
        /// Дата прибытия поезда
        /// </summary>
        public DateTime date2;

        /// <summary>
        /// Конструктор поезда
        /// </summary>
        /// <param name="machinist">Машинист</param>
        /// ![Image](../images/sheldon.jpg)
        /// <param name="route">Направление</param>
        /// <param name="quantity_coupe">Количество вагонов купе</param>
        /// <param name="quantity_econom">Количество плацкартных вагонов</param>
        public Train(string machinist, string route, int quantity_coupe, int quantity_econom)
        {
            this.machinist = machinist;
            this.route = route;
            this.quantity_coupe = quantity_coupe;
            this.quantity_econom = quantity_econom;
        }

        /// <summary>
        /// Определение вагонов-купе в поезде
        /// </summary>
        /// <param name="serial_number">Серийный номер поезда</param>
        /// <param name="seats">Количество мест для размещения пассажиров в вагоне-купе</param>
        /// <param name="price">Цена за место в вагоне-купе</param>
        /// <param name="conductor">Проводник вагона-купе</param>
        public void SetWagonCoupe(string[] serial_number, int[] seats, double[] price, string[] conductor) 
        {
            wagon_coupe = new Wagon_Coupe[quantity_coupe];
            for (int i = 0; i < quantity_coupe; i++)
            {
                wagon_coupe[i] = new Wagon_Coupe(serial_number[i], seats[i], price[i], conductor[i]);
            }
        }

        /// <summary>
        /// Определение плацкартного вагона в поезде
        /// </summary>
        /// <param name="serial_number">Серийный номер</param>
        /// <param name="seats">Количество мест для размещения пассажиров в плацкартном вагоне</param>
        /// <param name="price">Цена за место в плацкартном вагоне</param>
        /// <param name="conductor">Проводник плацкартного вагона</param>
        public void SetEconomWagon(string[] serial_number, int[] seats, double[] price, string[] conductor)
        {
            econom_wagon = new Econom_Wagon[quantity_econom];
            for (int i = 0; i < quantity_econom; i++)
            {
                econom_wagon[i] = new Econom_Wagon(serial_number[i], seats[i], price[i], conductor[i]);
            }
        }

        /// <summary>
        /// Вывод информации о поезде
        /// </summary>
        public void DisplayTrain()
        {
            Console.WriteLine("--------Состав поезда.--------");
            Console.WriteLine("Машинист: " + machinist);
            Console.WriteLine("Направление: " + route);
            for (int i = 0; i < quantity_coupe; i++)
            {
                wagon_coupe[i].Display();
            }
            for (int i = 0; i < quantity_econom; i++)
            {
                econom_wagon[i].Display();
            }
        }

        /// <summary>
        /// Расчёт времени поезда в пути
        /// </summary>
        /// \f$времяПути = датаПрибытия - датаОтбытия\f$
        /// <param name="d1">Дата отбытия</param>
        /// <param name="d2">Дата прибытия</param>
        public void TravelTime(DateTime d1, DateTime d2)
        {
            TimeSpan resTime = new TimeSpan();
            d1 = date1;
            d2 = date2;
            resTime = (d2 - d1).Duration();
            Console.WriteLine("Поезд прибудет через: " + " " + $"Дней:{resTime.Days} Часов:{resTime.Hours} Минут:{resTime.Minutes}");
        }
    }
}