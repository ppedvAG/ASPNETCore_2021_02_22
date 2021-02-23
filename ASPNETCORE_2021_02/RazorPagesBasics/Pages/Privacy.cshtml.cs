using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using RazorPagesBasics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesBasics.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        private readonly IConfiguration _configuration;

        public DateTime RegistrationDate { get; set; }
        public string Output { get; set; }
        public PrivacyModel(ILogger<PrivacyModel> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public void OnGet()
        {
            Output = _configuration["AppSettings:First"];



            var settings = _configuration.GetSection("AppSettings").Get<AppSettings>();
            RegistrationDate = settings.Car.RegistrationDate;
        }
    }
}
