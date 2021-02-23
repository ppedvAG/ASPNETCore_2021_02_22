using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesBasics.Pages.Modul002
{
    public class PartialViewSample3Model : PageModel
    {

        public string[] Tage { get; set; } = new string[7];

        public void OnGet()
        {
        }

        public PartialViewResult OnGetExcel()
        {
            for (int i = 0; i < 7; i++)
            {
                Tage[i] = Enum.GetName(typeof(DayOfWeek), i);
            }

            return Partial("_Excel", this);
        }
    }
}
