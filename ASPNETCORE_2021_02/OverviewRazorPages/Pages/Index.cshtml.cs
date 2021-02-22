using CarService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OverviewRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ICar _car; 

        public IndexModel(ILogger<IndexModel> logger, ICar myMockCar)
        {
            _logger = logger;
            _car = myMockCar;
        }

        public void OnGet()
        {

        }
    }
}
