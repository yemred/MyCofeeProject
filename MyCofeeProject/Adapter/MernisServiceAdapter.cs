using MernisServiceReference;
using MyCofeeProject.Abstract;
using MyCofeeProject.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCofeeProject.Adapter
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public  bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result =  client.TCKimlikNoDogrulaAsync(customer.NationalityId, customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year).Result;
            return result.Body.TCKimlikNoDogrulaResult;
        }
    }
}

