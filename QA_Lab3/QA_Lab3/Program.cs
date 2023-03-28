using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int coupe = 2;
            int econom = 1;
            Train train = new Train("Шелдон Купер", "Барнаул-Москва", coupe, econom);

            string[] coupe_serial_number = { "1111", "AAA2" };
            int[] coupe_seats = { 20, 21 };
            double[] coupe_price = { 400, 400 };
            string[] coupe_conductor = { "Антон Шапошников", "Петров Пётр" };

            
            train.SetWagonCoupe(coupe_serial_number, coupe_seats, coupe_price, coupe_conductor);
            

            string[] econom_serial_number = { "2222" };
            int[] econom_seats = { 30 };
            double[] econom_price = { 200 };
            string[] econom_conductor = { "Иван Иванов" };
            
            
            train.SetEconomWagon(econom_serial_number, econom_seats, econom_price, econom_conductor);
            
            train.DisplayTrain();

            train.date1 = new DateTime(2022, 4, 8, 19, 15, 0);
            train.date2 = new DateTime(2022, 4, 11, 8, 34, 0);
            train.TravelTime(train.date1, train.date2);

            Console.ReadKey();
        }
    }
}