using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesBasics.Pages.Modul004
{
    public class RouteDataSourceModel : PageModel
    {
        public int Ergebnis { get; set; }
        public int Eins { get; set; }
        public int Zwei { get; set; }


        public void OnGet()
        {
        }

        public IActionResult OnPostPlus()
        {
            Eins = int.Parse(Request.Form["eins"].FirstOrDefault());
            Zwei = int.Parse(Request.Form["zwei"].FirstOrDefault());

            Ergebnis = Eins + Zwei;

            return RedirectToPage("RouteDataDestination", "SingleOrder", new { orderId = Ergebnis });
        }


        public void OnPostMinus()
        {
            Eins = int.Parse(Request.Form["eins"].FirstOrDefault());
            Zwei = int.Parse(Request.Form["zwei"].FirstOrDefault());

            Ergebnis = Eins - Zwei;

            RedirectToPage("/Modul005/RouteDataDestination", "SingleOrder", new { orderId = Ergebnis });

        }
    }
}
