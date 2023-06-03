using MyScriptureJournal.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyScriptureJournal.Models
{
    public class Scriptures
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        
        public string? Book { get; set; }
        [Range(1, 100)]
        [Required]
        public string? Chapter { get; set; }
        [Range(1, 100)]
        [Required]
        public string? Verse { get; set; }

        [DataType(DataType.MultilineText)]
        public string? Note { get; set; }

        [Display(Name = "Date Added")]
        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }
    

        
    }

    
}
