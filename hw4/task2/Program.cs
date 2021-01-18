using System;
using System.Collections.Generic;
using System.Linq;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var customers = new List<Customer>();
            customers.Add(new Customer
            {
                Model = "CX-7",
                Name = "Alex",
                Phone = 000000000
            });
            customers.Add(new Customer
            {
                Model = "X-5",
                Name = "Tod",
                Phone = 111111111
            });
            customers.Add(new Customer
            {
                Model = "X-3",
                Name = "Foggy",
                Phone = 222222222
            });
            customers.Add(new Customer
            {
                Model = "CX-9",
                Name = "Neo",
                Phone = 333333333
            });

            var cars = new List<Car>();

            cars.Add(new Car
            {
                Brand = "Mazda",
                Color = "Red",
                Model = "CX-7",
                Year = 2010
            });

            cars.Add(new Car
            {
                Brand = "Mazda",
                Color = "Blue",
                Model = "CX-5",
                Year = 2015
            });

            cars.Add(new Car
            {
                Brand = "BMW",
                Color = "Black",
                Model = "X-5",
                Year = 2017
            });

            cars.Add(new Car
            {
                Brand = "BMW",
                Color = "White",
                Model = "X-3",
                Year = 2020
            });

            var result = from customer in customers
                         join car in cars on customer.Model equals car.Model
                         where customer.Name == "Foggy"
                         select new
                         {
                             car.Brand,
                             car.Color,
                             car.Year,
                             car.Model,
                             customer.Name,
                             customer.Phone
                         };
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadKey();
        }
    }
}
