using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CustomerRegs.Models;


namespace CustomerRegs.Controllers
{
    public class customerController : ApiController
    {
        public IHttpActionResult customerregform(customerClass customer)
        {
            customer1Entities1 nd = new customer1Entities1();
            nd.customers.Add(new customer()
            {
                c_name = customer.c_name,
                c_age=customer.c_age,
                c_gender=customer.c_gender

            }) ;
            nd.SaveChanges();
            return Ok();

        }
    }
}
