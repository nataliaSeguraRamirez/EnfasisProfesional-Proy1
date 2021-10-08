using System.ComponentModel.DataAnnotations;
using System;
namespace Proy1.Shared.Entity
{
    public class Movie
    {
        public int Id {get; set;} 
        [Required]public string Name{get;set;}
        public string Sinopsis{get;set;}
        public string Image{get;set;}
        public string Category {get;set;}
        public int Score {get;set;} 
        [Required] public DateTime Premier{get;set;}
    }
}