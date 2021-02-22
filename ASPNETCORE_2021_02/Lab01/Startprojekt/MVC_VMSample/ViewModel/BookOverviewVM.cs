using MVC_VMSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_VMSample.ViewModel
{
    public class BookOverviewVM
    {
        public IList<Book> ShowingBooks { get; set; }

        public bool IsAudioBook { get; set; } // Optional
        public string Query { get; set; } // Optional
        
    }
}
