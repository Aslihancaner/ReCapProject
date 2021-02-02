using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Id +" "+ item.BrandId+" "+item.Description);
            }
            Console.WriteLine("----------------------");
            Car car = new Car { Id = 7,BrandId=8,Description="Dizel Otomatik" };
            carManager.Add(car);
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Id + " " + item.BrandId+" "+item.Description);
            }
        }
    }
}
