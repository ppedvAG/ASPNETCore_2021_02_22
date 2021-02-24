using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

using BookshopDomain.Entites;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace Bookshop.Pages.Books
{
    public class CreateModel : PageModel
    {
        private string baseAdress = "https://localhost:44331/api/Books";

        public CreateModel()
        {

        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            string json = JsonConvert.SerializeObject(Book);

            var data = new StringContent(json, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.PostAsync(baseAdress, data);

                string result = await response.Content.ReadAsStringAsync();
            }


            return RedirectToPage("./Index");
        }
    }
}
