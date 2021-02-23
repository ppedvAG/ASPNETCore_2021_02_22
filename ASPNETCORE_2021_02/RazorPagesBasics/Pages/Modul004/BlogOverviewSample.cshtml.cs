using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesBasics.Pages.Modul004
{
    public class BlogOverviewSampleModel : PageModel
    {
        public void OnGet(int year, int month, int day, string title)
        {
        }
    }
}
