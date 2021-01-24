using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {

            using (DBContextTask4 db = new DBContextTask4())
            {
                var car1 = new Car() { Name = "CarTest1" };
                var car2 = new Car() { Name = "CarTest2" };
                var car3 = new Car() { Name = "CarTest3" };
                var car4 = new Car() { Name = "CarTest4" };

                var carManufacter1 = new CarManufacter() { Name = "CarManufacter1" };
                var carManufacter2 = new CarManufacter() { Name = "CarManufacter2" };
                var carManufacter3 = new CarManufacter() { Name = "CarManufacter3" };
                var carManufacter4 = new CarManufacter() { Name = "CarManufacter4" };

                var carMarket1 = new CarMarket() { Name = "CarMarket1" };
                var carMarket2 = new CarMarket() { Name = "CarMarket2" };
                var carMarket3 = new CarMarket() { Name = "CarMarket3" };
                var carMarket4 = new CarMarket() { Name = "CarMarket4" };

                car1.CarMarkets.Add(carMarket1);
                car1.CarMarkets.Add(carMarket2);
                car1.CarMarkets.Add(carMarket3);
                
                car2.CarMarkets.Add(carMarket1);
                car2.CarMarkets.Add(carMarket4);

                car1.CarManufactures.Add(carManufacter1);
                car2.CarManufactures.Add(carManufacter3);

                db.Car.Add(car1);
                db.Car.Add(car2);
                db.Car.Add(car3);
                db.Car.Add(car4);

                db.SaveChanges();
                var data = db.Car.ToList();

                foreach(var item in data)
                {
                    Console.WriteLine(item.Name);
                }

                Console.ReadKey();

            }
        }
    }
}
