## Modul02 - Lab (Razor Pages)

#### Startprojekt

F�r unsere zweite Lab m�ssen wir keine neue Webanwendung erstellen und k�nnen auf eine 
Start-Webanwendung zur�ck greifen.

In Modul01 haben wir gelernt, wie wir einen Service mithilfe des Seperation of Concern Konzept von ASP.NET Core einbinden und zugreifen k�nnen. 
Da wir in Modul02 eine Datenquelle verwenden, habe ich den Request-Counter Service gegen einen Book-Service ausgetauscht. 


Im Projektverzeichnis <i>Models</i> befindet sich die Klasse <i>Book</i>.  
In der Klasse Book werden alle Eigenschaften zusammengefasst, die ein Buch f�r unsere Beispiele beinhalten soll. 

```cs
namespace PPSAMPLE_BOOKSHOP.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }

        public bool AudioBook { get; set; } = false;
    }
}
```

Danach schauen wir in das Verzeichnis <b>Services</b>:

Das Interface-BookServices hat folgende Methoden f�r uns bereit gestellt:


```cs
public interface IBookService
{
    IList<Book> GetBooks(string query, bool onlyAudioBooks);

    int GetCount();

    Book GetById(int id);
}
```

| Methode | Beschreibung: |
| ------ | ------------ |
| IList<Book> GetBooks(string query, bool onlyAudioBooks) | Liefert eine Liste von B�chern zur�ck |
| int GetCount() | Liefert die Anzahl der verf�gbaren B�cker zur�ck |
| Book GetById(int id) | Liefert ein Buch mit der gleich Id zur�ck |



In der BookService-Klasse finden sie die Implementierung. 

- Die Datenquelle ist lediglich eine IList<Book>.
- Im Konstruktor werden die B�cherartikel in die Datenquelle geladen.

<br/>

```cs
public class BookService : IBookService
{
    private IList<Book> _bookService = new List<Book>();

    public BookService()
    {
        _bookService.Add( new Book { ID = 1, Title = "Heimweg", Author = "Fritzek", Price=10.99m});
        _bookService.Add( new Book { ID = 2, Title = "The Green Mile", Author = "Steven King", Price = 9.99m });
        _bookService.Add( new Book { ID = 3, Title = "ASP.NET WebForms", Author = "Hannes Preishuber", Price = 49.95m});
        _bookService.Add( new Book { ID = 4, Title = "Ein verhei�enes Land", Author = "Obama", Price = 49.95m});
        _bookService.Add( new Book { ID = 5, Title = "Ohne Schuld", Author = "Charlotte Link", Price = 19.99m });
        _bookService.Add( new Book { ID = 6, Title = "Ostfriesenzorn", Author = "Klaus-Peter Wolf", Price = 10.99m, AudioBook = true});
        _bookService.Add( new Book { ID = 7, Title = "Arbeitsweg", Author = "Fritzek", Price = 20m});
        _bookService.Add( new Book { ID = 8, Title = "Westfriesenlieb", Author = "Klaus-Peter Wolf", Price = 9.99m});
        _bookService.Add( new Book { ID = 9, Title = "Ostfriesenmelodie", Author = "Klaus-Peter Wolf", Price = 9.99m});
        _bookService.Add( new Book { ID = 10, Title = "Coding des Schreckens - Ein JavaScript Rundumblick", Author = "Kevin Winter", Price = 8.99m, AudioBook = true});
        _bookService.Add( new Book { ID = 11, Title = "Relaxed Yoga", Author = "Wiebkle Roland", Price = 12.99m });
        _bookService.Add( new Book { ID = 12, Title = "Der neunte Arm des Oktopus", Author = "Rossmann", Price = 19.99m, AudioBook = true });
    }

        ....
```

- Die Methode GetBooks liefert B�cherlisten und bieten mit den Parameter <i>string query</i> und <i>bool onlyAudioBooks=false</i> Filterm�glichkeiten an.

```cs 
public IList<Book> GetBooks(string query, bool onlyAudioBooks = false)
{
    IList<Book> results;
    if (string.IsNullOrEmpty(query))
    {
        if (onlyAudioBooks)
            results = _bookService.Where(q => q.AudioBook == onlyAudioBooks).ToList(); //Anzeige der gesamten Audio

        else
            results = _bookService.ToList();

    }
    else
    {
        if (onlyAudioBooks)
            results = _bookService.Where(q => q.Title.Contains(query) && q.AudioBook == onlyAudioBooks).ToList();
        else
            results = _bookService.Where(q => q.Title.Contains(query)).ToList();
    }

    return results;
}
```

- GetCount() gibt die Anzahl der vorhandenen B�cher in der IList<Book> zur�ck. 

```cs
public int GetCount()
{
    return _bookService.Count;
}
```

- GetById(int id) liefert das Buch mit der �bereinstimmenden id zur�ck. 

```cs
public Book GetById(int id)
{
    return _bookService.Where(n => n.ID == id).FirstOrDefault();
}
```

In der Startup.cs wird schlussendlich der Service als AddSingleton<IBookServices, BookServices>() registriert. 

```cs
// This method gets called by the runtime. Use this method to add services to the container.
public void ConfigureServices(IServiceCollection services)
{
    services.AddSingleton<IBookService, BookService>();
    services.AddRazorPages();
}
```


### Aufgabe:

Unsere Aufgabe wird sein, dass wir f�r vorhandene Backend-Struktur mithilfe von Razor Pages das Frontend erarbeiten.  

In diesem Modul erstellen wir zwei Razor Pages mit den jeweiligen ToDos: 

- Index 
  - �bersicht �ber alle Buchartikel
  - Filterungsm�glichkeit nach Name und ob nur H�rb�cher gezeigt werden
  - Eine Verlinkung auf die Detail-Seite, je Buchartikel

- Details
  - detailierte �bersicht �ber den ausgew�hlten Buchartikel
  - Eine Verlinkung zur�ck zur Index-Razor Page
 
> ### Index Razor Page -Implementierung 
>> ##### 1.) Erstellen der Index-Razor Pages
>>Um eine RazorPages innerhalb unserers Pages\Book - Ordners anzulegen:
>>- klicken wir mit einem rechtsklick auf den Ordner Book.
>>- Im Popup-Men� w�hlen wir den Eintrag "Hinzuf�gen oder Add"->Razor Pages aus. (siehe Screenshot unterhalb)
>><img src="../../../MD_BaseFiles/Meta/pic/LAB002_RazorPage_2.jpg" alt="drawing" width="600"/>
>>Im folgenden Dialog-Fenster, wird Razor Pages vorselektiert und klicken auf Hinzuf�gen. 
>><img src="../../../MD_BaseFiles/Meta/pic/LAB002_RazorPage_3.jpg" alt="drawing" width="600"/>
>>- Im n�chsten Dialog, definieren wir unsere RazorPages mit dem Namen Index.cshtml. 
>>- Klicken Hinzuf�gen
>><img src="../../../MD_BaseFiles/Meta/pic/LAB002_RazorPage_4.jpg" alt="drawing" width="600"/>
>>- Abschlie�en muss die Projekt-Mappe so ausschauen:
>><img src="../../../MD_BaseFiles/Meta/pic/LAB002_RazorPage_5.jpg" alt="drawing" width="600"/>

>>##### 2.) Implementieren des IndexModel (PageModel-Klasse)
>>[Theorie]</br>
>>Was ist ein Razor Page Model?</br>
>>Der Hauptzweck der PageModel-Klasse von Razor Pages besteht darin, eine klare Trennung zwischen der UI-Ebene (der CSHTml- Ansichtsdatei ) und der Verarbeitungslogik f�r die Seite bereitzustellen . Es gibt eine Reihe von Gr�nden, warum diese Trennung vorteilhaft ist:
>>- Dies reduziert die Komplexit�t der UI-Ebene und erleichtert die Wartung.
>>- Es erleichtert das automatisierte Testen von Einheiten.
>>- Dies erm�glicht Teams eine gr��ere Flexibilit�t, da ein Mitglied an der Ansicht arbeiten kann, w�hrend ein anderes Mitglied an der Verarbeitungslogik arbeiten kann.
>>- Es werden kleinere, wiederverwendbare Codeeinheiten f�r bestimmte Zwecke empfohlen, was die Wartung und Skalierbarkeit unterst�tzt (dh die Leichtigkeit, mit der die Codebasis der Anwendung hinzugef�gt werden kann, um zus�tzlichen zuk�nftigen Anforderungen gerecht zu werden).
>>- Wir �ffnen die Index.cshtml.cs - Datei:
>>- Zuerst definieren wir unseren IBookService
>>- Die B�cher die sp�ter auf der Razor-View angezeigt werden, befinden sich in der IList<Book>
>>- Das Flag IsAudioBook ist dann auf True, wenn ShowingBooks nur H�rb�cher anzeigt.
>>> Implementieren des IndexModel - Variablen und Konstruktor mit DI
>>>```cs
>>>public class IndexModel : PageModel
>>>{
>>>    private IBookService _service;
>>>
>>>    [BindProperty]
>>>    public IList<Book> ShowingBooks { get; set; }
>>>
>>>    [BindProperty]
>>>    public bool IsAudioBook { get; set; }
>>>        
>>>
>>>    public IndexModel([FromServices] IBookService service)
>>>    {
>>>        _service = service;
>>>    }
>>>}
>>>```
>>> Implementieren des IndexModel - Get-Methoden
>>>##### 3.) Implementieren von Get-Methoden
>>>
>>>```cs
>>>public void OnGet()
>>>{
>>>    ShowingBooks = _service.GetBooks(string.Empty, false);
>>>}
>>>
>>>public void OnGetAudioBooks()
>>>{
>>>    ShowingBooks = _service.GetBooks(string.Empty, true);
>>>}
>>>```
>>> Implementieren des IndexModel - Post-Methode
>>>##### 4.) Implementieren von Post-Methoden
>>>
>>>```cs
>>>public void OnPostSearch ()
>>>{
>>>    string query = HttpContext.Request.Form["query"].ToString();
>>>
>>>    ShowingBooks = _service.GetBooks(query, IsAudioBook);
>>>}
>>>```
>>><b>Nach diesem Codestand sollte das Projekt ohne Fehler kompilieren.</b>

>>>##### 5.) Implementieren der RazorView Page
>>```html
>>@page "{handler?}"
>>@model PPSAMPLE_BOOKSHOP.Pages.Books.IndexModel
>>@{
>>}
>><form method="post">
>>    <table class="table">
>>        <thead>
>>            <tr>
>>                <th>
>>                    @Html.DisplayNameFor(model => model.ShowingBooks[0].ID)
>>                </th>
>>                <th>
>>                    @Html.DisplayNameFor(model => model.ShowingBooks[0].Title)
>>                </th>
>>                <th>
>>                    @Html.DisplayNameFor(model => model.ShowingBooks[0].Author)
>>                </th>
>>                <th>
>>                    @Html.DisplayNameFor(model => model.ShowingBooks[0].Price)
>>               </th>
>>                <th></th>
>>            </tr>
>>        </thead>
>>        <tbody>
>>            @foreach (var item in Model.ShowingBooks)
>>            {
>>
>>                <tr>
>>                    <td>
>>                        @Html.DisplayFor(modelItem => item.ID)
>>                    </td>
>>                    <td>
>>                        @Html.DisplayFor(modelItem => item.Title)
>>                    </td>
>>                    <td>
>>                        @Html.DisplayFor(modelItem => item.Author)
>>                    </td>
>>                    <td>
>>                        @Html.DisplayFor(modelItem => item.Price)
>>                    </td>
>>                    <td>
>>                        <a asp-page="" asp-page-handler="Details" asp-route-id="@item.ID">Details</a>
>>                    </td>
>>                </tr>
>>            }
>>    </table>
>></form>
>>```

>>##### 6.) Implementieren einer Suchbox mit H�rbuch-Filter
>>
>>```html
>>@page "{handler?}"
>>@model PPSAMPLE_BOOKSHOP.Pages.Books.IndexModel
>>@{
>>}
>>
>><form method="post">
>>    <p>Suchbegriff</p>
>>    <input id="query" type="text" name="query" />
>>
>>    <p>Nur H�rbucher anzeigen?</p>
>>    <input type="checkbox" asp-for="IsAudioBook" />
>>    <button asp-page-handler="search" type="submit">Search</button>
>></form>
>>
>><form method="post">
>>    <table class="table">
>>        <thead>
>>            <tr>
>>                <th>
>>                    @Html.DisplayNameFor(model => model.ShowingBooks[0].ID)
>>                </th>
>>                <th>
>>                    @Html.DisplayNameFor(model => model.ShowingBooks[0].Title)
>>                </th>
>>                <th>
>>                    @Html.DisplayNameFor(model => model.ShowingBooks[0].Author)
>>                </th>
>>                <th>
>>                    @Html.DisplayNameFor(model => model.ShowingBooks[0].Price)
>>                </th>
>>                <th></th>
>>            </tr>
>>        </thead>
>>        <tbody>
>>            @foreach (var item in Model.ShowingBooks)
>>            {
>>
>>               <tr>
>>                    <td>
>>                        @Html.DisplayFor(modelItem => item.ID)
>>                    </td>
>>                    <td>
>>                        @Html.DisplayFor(modelItem => item.Title)
>>                    </td>
>>                    <td>
>>                        @Html.DisplayFor(modelItem => item.Author)
>>                    </td>
>>                    <td>
>>                        @Html.DisplayFor(modelItem => item.Price)
>>                    </td>
>>                    <td>
>>                        <a asp-page="" asp-page-handler="Details" asp-route-id="@item.ID">Details</a>
>>                    </td>
>>                </tr>
>>            }
>>        </tbody>
>>    </table>

>### Details - RazorPage Implementierung

>>##### 1.) Erstell der Details - Razor Pages
>>- klicken wir mit einem rechtsklick auf den Ordner Book.
>>- Im Popup-Men� w�hlen wir den Eintrag "Hinzuf�gen oder Add"->Razor Pages aus. (siehe Screenshot unterhalb)
>><img src="../../../MD_BaseFiles/Meta/pic/LAB002_RazorPage_2.jpg" alt="drawing" width="600"/>
>>Im folgenden Dialog-Fenster, wird Razor Pages vorselektiert und klicken auf Hinzuf�gen. 
>><img src="../../../MD_BaseFiles/Meta/pic/LAB002_RazorPage_3.jpg" alt="drawing" width="600"/>
>>- Im n�chsten Dialog, definieren wir unsere RazorPages mit dem Namen Details.cshtml. 
>>- Klicken Hinzuf�gen

>>##### 2.) Implementieren der DetailsModel (PageModel-Klasse)
>>```cs
>>using System;
>>using Microsoft.AspNetCore.Mvc.RazorPages;
>>using PPSAMPLE_BOOKSHOP.Models;
>>using PPSAMPLE_BOOKSHOP.Service;
>>
>>namespace PPSAMPLE_BOOKSHOP.Pages.Books
>>{
>>    public class DetailsModel : PageModel
>>    {
>>        private readonly IBookService _service;
>>        public Book SelectedBook { get; set; }
>>
>>        public DetailsModel(IBookService service)
>>        {
>>            _service = service;
>>        }
>>
>>
>>        public void OnGet(int? id)
>>        {
>>            if (!id.HasValue)
>>                throw new ArgumentException();
>>
>>            SelectedBook = _service.GetById(id.Value);
>>        }
>>    }
>>}
>>```

>>##### 3.) Designen der Details RazorView
>>```html
>>@page
>>@model PPSAMPLE_BOOKSHOP.Pages.Books.DetailsModel
>>@{
>>}
>>
>><h1>Details</h1>
>>
>><div>
>>    <h4>Aufgaben</h4>
>>    <hr />
>>    <dl class="row">
>>        <dt class="col-sm-2">
>>            @Html.DisplayNameFor(model => model.SelectedBook.ID)
>>        </dt>
>>        <dd class="col-sm-10">
>>            @Html.DisplayFor(model => model.SelectedBook.ID)
>>        </dd>
>>        <dt class="col-sm-2">
>>            @Html.DisplayNameFor(model => model.SelectedBook.Title)
>>        </dt>
>>        <dd class="col-sm-10">
>>            @Html.DisplayFor(model => model.SelectedBook.Title)
>>        </dd>
>>        <dt class="col-sm-2">
>>            @Html.DisplayNameFor(model => model.SelectedBook.Author)
>>        </dt>
>>        <dd class="col-sm-10">
>>            @Html.DisplayFor(model => model.SelectedBook.Author)
>>        </dd>
>>        <dt class="col-sm-2">
>>            @Html.DisplayNameFor(model => model.SelectedBook.Price)
>>        </dt>
>>        <dd class="col-sm-10">
>>            @Html.DisplayFor(model => model.SelectedBook.Price)
>>        </dd>
>>        <dt class="col-sm-2">
>>            @Html.DisplayNameFor(model => model.SelectedBook.AudioBook)
>>        </dt>
>>        <dd class="col-sm-10">
>>            @Html.DisplayFor(model => model.SelectedBook.AudioBook)
>>        </dd>
>>    </dl>
>></div>
>><div>
>>    <a asp-page="./Index">Back to List</a>
>></div>


### Implementieren der Create RazorPage-Seite

##### Code-Behind: CreatModel
```cs
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using PPSAMPLE_BOOKSHOP.Models;
using PPSAMPLE_BOOKSHOP.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PPSAMPLE_BOOKSHOP.Pages.Club
{
    public class CreateModel : PageModel
    {
        private readonly IBookService _service;

        public CreateModel(IBookService service)
        {
            _service = service;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Book NewBook { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public IActionResult OnPost(IFormFile datei)
        {
            NewBook = _service.InserBook(NewBook);


            return RedirectToPage("./Index");
        }
    }
}
```


##### Design: RazorPages - Create
```html
@page
@model PPSAMPLE_BOOKSHOP.Pages.Club.CreateModel

@{
    ViewData["Title"] = "Create";
    Layout = "~/Pages/Shared/_Layout.cshtml";
}

<h1>Erstelle</h1>

<h4>Neues Buch</h4>
<hr />
<div class="row">
    <div class="col-md-4">
        <form enctype="multipart/form-data" method="post">
            <div asp-validation-summary="All" class="text-danger"></div>
            <div class="form-group">
                <label asp-for="NewBook.Title" class="control-label"></label>
                <input asp-for="NewBook.Title" class="form-control" />
                <span asp-validation-for="NewBook.Title" class="text-danger"></span>
            </div>
            <div class="form-group">
                <label asp-for="NewBook.Author" class="control-label"></label>
                <input asp-for="NewBook.Author" class="form-control" />
                <span asp-validation-for="NewBook.Author" class="text-danger"></span>
            </div>
            <div class="form-group">
                <label asp-for="NewBook.Price" class="control-label"></label>
                <input asp-for="NewBook.Price" class="form-control" />
                <span asp-validation-for="NewBook.Price" class="text-danger"></span>
            </div>
            
            <div class="form-group">
                <input type="submit" value="Create" class="btn btn-primary" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-page="Index">Back to List</a>
</div>

@section Scripts {
    @{await Html.RenderPartialAsync("_ValidationScriptsPartial");}
}

```

