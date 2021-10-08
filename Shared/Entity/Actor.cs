using System.ComponentModel.DataAnnotations;
using System; 
namespace Proy1.Shared.Entity
{
    public class Actor
    {
        public int Id{get;set;}
        [Required] public string Name{get;set;}
        [Required] public DateTime BirthDate {get;set;}
        public string Photo{get;set;}
        [Required] public string Biography{get;set;}
    }
}