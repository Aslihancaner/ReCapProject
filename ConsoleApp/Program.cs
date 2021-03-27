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
            //CarManagerTest();
            //BrandManagerTest();
            //ColorManagerTest();
            //CustomerManagerTest();
            //RentalManagerTest();
            //UserManagerTest();
        }

        private static void UserManagerTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var result = userManager.GetAll();
            foreach (var item in result.Data)
            {
                Console.WriteLine(item.FirstName + "---" + item.LastName);
            }
        }
        private static void RentalManagerTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.GetAll();

            foreach (var item in result.Data)
            {
                Console.WriteLine(item.Id + " " + item.RentDate);
            }
        }
        private static void CustomerManagerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Customer customer = new Customer { CompanyName = "Yarı fiyatına", UserId = 1 };
            //customerManager.Add(customer);
            customerManager.Update(new Customer
            {
                CustomerId = 1,
                CompanyName = "Yarı fiyatına kampanyası",
                UserId = 1
            });
            var result = customerManager.GetAll();
            foreach (var item in result.Data)
            {
                Console.WriteLine(item.UserId + " " + item.CompanyName);

            }
        }
        private static void ColorManagerTest()
        {
            ColorManager coloManager = new ColorManager(new EfColorDal());
            var result = coloManager.GetAll();
            foreach (var item in result.Data)
            {
                Console.WriteLine(item.ColorId + " " + item.ColorName);
            }
        }
        private static void BrandManagerTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //Brand brand = new Brand { BrandName = "BMW" };
            //brandManager.Add(brand);
            var result = brandManager.GetAll();
            foreach (var item in result.Data)
            {
                Console.WriteLine(item.BrandId + " " + item.BrandName);
            }
        }
        private static void CarManagerTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAll();
            foreach (var item in result.Data)
            {
                Console.WriteLine(item.Description);
            }
        }
    }
}
