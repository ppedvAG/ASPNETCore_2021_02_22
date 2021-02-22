using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesBasics.Pages.Modul001
{
    public class Calc1Model : PageModel
    {
        public int Ergebnis { get; set; }


        //OnGet wird beim Aufruf von localhost:12345/Beispiel1/Calc1
        public void OnGet()
        {
            Ergebnis = 0;
        }
    }
}
