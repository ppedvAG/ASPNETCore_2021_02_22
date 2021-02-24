using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesBasics.Pages.Modul005
{
    public class ViewDataSampleModel : PageModel
    {
        public void OnGet()
        {
            ViewData.Add("Email", "KevinW@PPEDV.de");
        }
    }
}
