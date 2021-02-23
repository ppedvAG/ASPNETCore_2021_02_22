using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesBasics.Pages.Modul003
{
    public class GallerySample1Model : PageModel
    {
        public string[] Bilder { get; set; }


        public void OnGet()
        {
            var pfad = AppDomain.CurrentDomain.GetData("BildVerzeichnis") + @"\images\";

            Bilder = Directory.GetFiles(pfad);
        }
    }
}