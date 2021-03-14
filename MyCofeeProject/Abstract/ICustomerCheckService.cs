using MyCofeeProject.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCofeeProject.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);

    }
}
