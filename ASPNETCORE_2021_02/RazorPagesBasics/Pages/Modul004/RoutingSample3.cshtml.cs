using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesBasics.Pages.Modul004
{
    public class RoutingSample3Model : PageModel
    {
        public string Title { get; set; }
        public void OnGet(string title)
        {
            Title = title;
        }
    }
}
