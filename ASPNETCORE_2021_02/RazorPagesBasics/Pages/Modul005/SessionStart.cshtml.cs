using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesBasics.Models;

namespace RazorPagesBasics.Pages.Modul005
{
    public class SessionStartModel : PageModel
    {
        public void OnGet()
        {
            HttpContext.Session.SetString("keyabc", "Hi");
            HttpContext.Session.SetInt32("keydef", 25);




            IMyCar car = new MyCar();
            car.Brand = "VW";
            car.Modell = "Polo";
            car.ConstructionAt = DateTime.Now;

            string jsonString = JsonSerializer.Serialize(car);

            HttpContext.Session.SetString("MyObj", jsonString);

        }
    }
}
