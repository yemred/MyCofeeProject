using MyCofeeProject.Abstract;
using MyCofeeProject.Adapter;
using MyCofeeProject.Concrete;
using System;

namespace MyCofeeProject
{
    class Program
    {
        static void Main(string[] args)
        {

            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());

            customerManager.Save(new Customer
            {


                NationalityId = 49087559019,
                DateOfBirth = new DateTime(1990, 8, 13),
                FirstName = "Yunus Emre",
                LastName = "Duymaz"

            });

            Console.ReadLine();
  
        }
    }
}
