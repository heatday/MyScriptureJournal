

using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesScripturesContext(
                serviceProvider.GetRequiredService<DbContextOptions<RazorPagesScripturesContext>>()))
            {
                if (context == null || context.Movie == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any scriptures.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Scriptures
                    {
                        Book = "John",
                        Chapter = "3",
                        Verse = "16",
                        Note = "For God so loved the world...",
                        DateAdded = DateTime.Parse("2023-05-28")
                    },

                    new Scriptures
                    {
                        Book = "Psalms",
                        Chapter = "23",
                        Verse = "1",
                        Note = "The Lord is my shepherd...",
                        DateAdded = DateTime.Parse("2023-05-29")
                    },

                    new Scriptures
                    {
                        Book = "Matthew",
                        Chapter = "6",
                        Verse = "33",
                        Note = "Seek first the kingdom of God...",
                        DateAdded = DateTime.Parse("2023-05-30")
                    },

                    new Scriptures
                    {
                        Book = "2 Nephi",
                        Chapter = "2",
                        Verse = "25",
                        Note = "Adam fell that men might be...",
                        DateAdded = DateTime.Parse("2023-06-10")
                    },

                    new Scriptures
                    {
                        Book = "Alma",
                        Chapter = "32",
                        Verse = "21",
                        Note = "Faith is not to have a perfect...",
                        DateAdded = DateTime.Parse("2023-06-11")
                    },

                    new Scriptures
                    {
                        Book = "Moroni",
                        Chapter = "10",
                        Verse = "4",
                        Note = "And when ye shall receive these...",
                        DateAdded = DateTime.Parse("2023-06-14")
                    },

                    new Scriptures
                    {
                        Book = "Doctrine and Covenants",
                        Chapter = "88",
                        Verse = "118",
                        Note = "Seek learning, even by study...",
                        DateAdded = DateTime.Parse("2023-06-01")
                    },

                    new Scriptures
                    {
                        Book = "Moses",
                        Chapter = "1",
                        Verse = "1",
                        Note = "The words of God...",
                        DateAdded = DateTime.Parse("2023-06-02")
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
