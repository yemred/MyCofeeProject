using MyCofeeProject.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCofeeProject.Abstract
{
    public class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Müşteri Kaydedildi");
        }
    }
}
