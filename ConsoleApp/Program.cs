using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.GetAll().ForEach(c => Console.WriteLine(c));
            //carManager.GetCarDetails().ForEach(g => Console.WriteLine(g));
           
            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.GetAll().ForEach(b => Console.WriteLine(b));
           
            //ColorManager colorManager = new ColorManager(new EfColorDal());                  
            //colorManager.GetAll().ForEach(c => Console.WriteLine(c));

            
        }
    }
}
