using domain;
using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class avisController : Controller
    {
        // GET: avis
        public ActionResult Index()
        {
          
                HttpClient client = new HttpClient();
                HttpClient Client = new HttpClient();
                Client.BaseAddress = new Uri("http://localhost:9080");
                Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = Client.GetAsync("projetintegre-web/rest/employee").Result;
                if (response.IsSuccessStatusCode)
                {
                    ViewBag.result = response.Content.ReadAsAsync<IEnumerable<avis>>().Result;
                }
                else
                {
                    ViewBag.result = "erroe";
                }

          
            return View();


        }
    }
}