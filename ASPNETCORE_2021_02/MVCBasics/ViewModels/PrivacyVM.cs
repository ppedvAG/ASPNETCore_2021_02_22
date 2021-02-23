using MVCBasics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBasics.ViewModels
{
    public class PrivacyVM
    {
        // Daten die Richtugn DB gehen
        public Person Person { get; set; }



        // Daten die zusätzlich im Formulat angezeigt werden 
        public bool IsAnyCheckboxPushed { get; set; }
        //UI ht eine Textbox mit Pfad Editierung
        public string PathForMedias { get; set; }

    }
}
