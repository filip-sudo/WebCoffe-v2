using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebCoffe.Models
{
    [Table("kava")]
    public class Kava
    {
        [Key]
        [Column("id")]
        [Display(Name = "ID Kave")]
        public int Id { get; set; } 

        [Column("naziv")]
        [Display(Name = "Naziv Kave")]
        [Required(ErrorMessage = "{0} je obavezno")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "{0} mora biti duljine minimalno {2}, a maksimalno {1} znakova")]
        public string Naziv { get; set; }

        [Column("cijena")]
        [Display(Name = "Cijena Kave")]
        [Required(ErrorMessage = "{0} je obavezno")]
        public int Cijena { get; set; }
    }
}