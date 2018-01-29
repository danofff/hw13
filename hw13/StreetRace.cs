using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw13
{
   
    static class Programm
    {
        static void Main()
        {
            // Создаем заезд
            Race r = new Race();

            // Создаем машины
            Car car1 = new SportCar();
            Car car2 = new Truck();
            Car car3 = new Bus();

            // Подписываемся на участие в игре
            car1.JoinGame(r);
            car2.JoinGame(r);
            car3.JoinGame(r);
           
            // Запуск заезда
            r.Run();

            // Победитель
            Console.WriteLine("Победил " + r.Winner);

            Console.ReadLine();
        }

    }
}
