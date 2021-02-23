using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesBasics.Pages.Modul004
{
    public class ConstraintsSampleModel : PageModel
    {
        public int Id { get; set; }
        public void OnGet(int? id)
        {
             Id = id.Value * 2;
        }
    }
}
