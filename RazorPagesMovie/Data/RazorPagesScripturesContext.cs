using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Models;


namespace MyScriptureJournal.Data
{
    public class RazorPagesScripturesContext : DbContext
    {
        public RazorPagesScripturesContext (DbContextOptions<RazorPagesScripturesContext> options)
            : base(options)
        {
        }

        public DbSet<MyScriptureJournal.Models.Scriptures> Movie { get; set; } = default!;
     
        public object Scriptures { get; internal set; }
    }
}
