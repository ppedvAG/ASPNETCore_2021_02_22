 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PPSAMPLE_BOOKSHOP.Models;
using PPSAMPLE_BOOKSHOP.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PPSAMPLE_BOOKSHOP.Pages.Books
{
    public class IndexModel : PageModel
    {
        private IBookService _service;

        [BindProperty]
        public IList<Book> ShowingBooks { get; set; }


        //public bool CurrentFilter { get; set; }
        [BindProperty]
        public bool IsAudioBook { get; set; }

        [BindProperty]
        public string Query { get; set; }
        

        public IndexModel([FromServices] IBookService service)
        {
            _service = service;
        }

        public void OnGet()
        {
            ShowingBooks = _service.GetBooks(string.Empty, false);
        }

        public void OnGetAudioBooks()
        {
            ShowingBooks = _service.GetBooks(string.Empty, true);
        }

        public void OnPostSearch ()
        {

            if (string.IsNullOrEmpty(Query))
            {

            }

            bool isAudio = Convert.ToBoolean(HttpContext.Request.Form["isAudio"]);
            string query = HttpContext.Request.Form["query"].ToString();

            ShowingBooks = _service.GetBooks(query, IsAudioBook);
        }

       
    }
}
