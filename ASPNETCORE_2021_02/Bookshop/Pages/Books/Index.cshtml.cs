using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BookshopDomain.Entites;
using System.Net.Http;
using Newtonsoft.Json;

namespace Bookshop.Pages.Books
{
    public class IndexModel : PageModel
    {
        private string baseAdress = "https://localhost:44331/api/Books";

        public IndexModel()
        {
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            HttpClient client = new HttpClient();

            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Get, baseAdress);
            HttpResponseMessage response = await client.SendAsync(message);

            string jsonText = await response.Content.ReadAsStringAsync();

            Book = JsonConvert.DeserializeObject<List<Book>>(jsonText);
        }
    }
}
