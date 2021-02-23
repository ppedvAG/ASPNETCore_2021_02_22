using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesBasics.Pages.Modul004
{
    public class BlogOverviewSample2Model : PageModel
    {
        private int _year;
        private int _month;
        private int _day;

        public void OnGet(int year, int month, int day)
        {
            _year = year;
            _month = month;
            _day = day;
        }
    }
}
