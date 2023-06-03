using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages.Movies
{

    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Data.RazorPagesScripturesContext _context;
       
        public IndexModel(MyScriptureJournal.Data.RazorPagesScripturesContext context)
        {
            _context = context;
        }

        public IList<Models.Scriptures> Movie { get; set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? SortBy { get; set; }

        //public SelectList? Genres { get; set; }
        public SelectList? Genres { get; set; }


        [BindProperty(SupportsGet = true)]
        public string? MovieGenre { get; set; }

       


        public async Task OnGetAsync()
        {
            // Use LINQ to get list of genres.
          
            IQueryable<string> genreQuery = from m in _context.Movie
                                           orderby m.Book
                                            select m.Book;

            var movies = from m in _context.Movie
                         select m;

          

            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Book.Contains(SearchString) || s.Note.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(MovieGenre))
            {
                movies = movies.Where(x => x.Book == MovieGenre);
            }
            

            if (!string.IsNullOrEmpty(SortBy))
            {
                if (SortBy.ToLower() == "book")
                {
                    movies = movies.OrderBy(m => m.Book);
                }
                else if (SortBy.ToLower() == "date")
                {
                    movies = movies.OrderBy(m => m.DateAdded);
                }
            }
            else
            {
                movies = movies.OrderBy(m => m.Book);
            }

            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
            Movie = await movies.ToListAsync();
        }
      

    }
}
