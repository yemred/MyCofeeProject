using MyCofeeProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCofeeProject.Concrete
{
    public class NeroCustomerManager : BaseCustomerManager
    {
        public override void Save(Customer customer)
        {
            base.Save(customer);
        }

    }
}
