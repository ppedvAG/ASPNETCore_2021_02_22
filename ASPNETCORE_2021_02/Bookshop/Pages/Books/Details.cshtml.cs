using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BookshopDomain.Entites;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

;

namespace Bookshop.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private string baseAdress = "https://localhost:44331/api/Books/";

        public DetailsModel()
        {
           
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            string url = baseAdress + id.ToString();

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                string jsonText = await response.Content.ReadAsStringAsync();

                Book = JsonConvert.DeserializeObject<Book>(jsonText);
            }


            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
