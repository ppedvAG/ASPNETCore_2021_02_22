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
    public class DetailsModel : PageModel
    {
        private readonly IBookService _service;

        public Book SelectedBook { get; set; }

        public DetailsModel(IBookService service)
        {
            _service = service;
        }

        
        public void OnGet(int? id)
        {
            if (!id.HasValue)
                throw new ArgumentException();

            SelectedBook = _service.GetById(id.Value);
        }
    }
}
