using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesBasics.Pages.Modul003
{
    public class PictureUploadSampleModel : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost(IFormFile datei)
        {
            FileInfo fileInfo = new FileInfo(datei.FileName);

            var absolutFilePath = AppDomain.CurrentDomain.GetData("BildVerzeichnis") + @"\images\" + fileInfo.Name;

            using (var fs = new FileStream(absolutFilePath, FileMode.Create))
            {
                datei.CopyTo(fs);
            }
        }
    }
}
