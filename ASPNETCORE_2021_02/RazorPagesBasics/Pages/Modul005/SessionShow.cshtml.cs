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
    public class SessionShowModel : PageModel
    {
        public void OnGet()
        {
            string Name = HttpContext.Session.GetString("keyabc");

            int? Age = HttpContext.Session.GetInt32("keydef");

            if (Age.HasValue)
            {
                //Mach was mit der Variable Age (kleine Exkursus in nullable datatype
            }

            string jsonString = HttpContext.Session.GetString("MyObj");
            IMyCar car = JsonSerializer.Deserialize<MyCar>(jsonString);
        }
    }
}
