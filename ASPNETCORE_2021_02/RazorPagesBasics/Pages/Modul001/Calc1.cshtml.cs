using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorPagesBasics.Pages.Modul001
{
    public class Calc1Model : PageModel
    {
        public int Ergebnis { get; set; }
        private ILogger<Calc1Model> _logger;

        private Person myPerson { get; set; }



        public Calc1Model(ILogger<Calc1Model> logger)
        {
            _logger = logger;
        }
        //OnGet wird beim Aufruf von localhost:12345/Beispiel1/Calc1
        public void OnGet()
        {
            _logger.LogInformation("Calc1Model - OnGet()");
            Ergebnis = 0;
        }
    }
}
