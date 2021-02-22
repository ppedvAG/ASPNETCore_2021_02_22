using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesBasics.Pages.Modul001
{
    public class Calc3Model : PageModel
    {
        public void OnGet()
        {
        }

        public int Ergebnis { get; set; }
        public int Eins { get; set; }
        public int Zwei { get; set; }

        public void OnPostPlus()
        {
            Eins = int.Parse(Request.Form["eins"].FirstOrDefault());
            Zwei = int.Parse(Request.Form["zwei"].FirstOrDefault());

            Ergebnis = Eins + Zwei;
        }

        public void OnPostMinus()
        {
            Eins = int.Parse(Request.Form["eins"].FirstOrDefault());
            Zwei = int.Parse(Request.Form["zwei"].FirstOrDefault());

            Ergebnis = Eins - Zwei;
        }

    }
}
