using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using PPSAMPLE_BOOKSHOP.Models;
using PPSAMPLE_BOOKSHOP.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PPSAMPLE_BOOKSHOP.Pages.Club
{
    public class CreateModel : PageModel
    {
        private readonly IBookService _service;

        public CreateModel(IBookService service)
        {
            _service = service;
        }

        public IActionResult OnGet()
        {
            return Page();
        }



        [BindProperty]
        public Book NewBook { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public IActionResult OnPost()
        {

            // Noch mehr Logik
            //ModelState.AddModelError("Reissack", "umgefallen");

            if (ModelState.IsValid)
            {
                NewBook = _service.InserBook(NewBook);


                return RedirectToPage("./Index");
            }

            return Page();
        }
    }
}
