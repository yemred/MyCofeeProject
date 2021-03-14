using MernisServiceReference;
using MyCofeeProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCofeeProject.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer) // test için bu kullanılabilir.
        {

            return true;
       
        }
    }
}
