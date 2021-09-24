using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomerRegs.Models;
using System.Net.Http;


namespace CustomerRegs.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(customerClass customer)
        {
            if (ModelState.IsValid)
            {
                HttpClient hc = new HttpClient();
                hc.BaseAddress = new Uri("https://localhost:44306/api/customerController");

                var insertrec = hc.PostAsJsonAsync<customerClass>("customer", customer);
                insertrec.Wait();

                var saverec = insertrec.Result;
                if (saverec.IsSuccessStatusCode)
                {

                    ViewBag.message = "the customer" + customer + "is inserted successfully!";
                }

            }
            return View();


        }
    }
}

