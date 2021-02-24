using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesBasics.Pages.Modul005
{
    public class TempDataStartModel : PageModel
    {

        public void OnGet()
        {
            TempData.Add("MyEmail", "KevinW@PPEDV.de");
        }
    }
}
