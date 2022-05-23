using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebCoffe.Models
{
    [Table("narudzba")]
    public class Narudzba
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("ime")]
        [Required(ErrorMessage = "{0} je obavezno")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "{0} mora biti duljine minimalno {2}, a maksimalno {1} znakova")]
        [Display(Name = "Ime")]
        public string Ime { get; set; }

        [Column("prezime")]
        [Required(ErrorMessage = "{0} je obavezno")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "{0} mora biti duljine minimalno {2}, a maksimalno {1} znakova")]
        [Display(Name = "Prezime")]
        public string Prezime { get; set; }

        [Column("telefon")]
        [Required(ErrorMessage = "{0} je obavezno")]
        [Display(Name = "Broj telefona")]
        public int Telefon { get; set; }

        [Column("adresa")]
        [Required(ErrorMessage = "{0} je obavezno")]
        [StringLength(45, MinimumLength = 3, ErrorMessage = "{0} mora biti duljine minimalno {2}, a maksimalno {1} znakova")]
        [Display(Name = "Adresa stanovanja")]
        public string Adresa { get; set; }

        [Column("grad")]
        [Required(ErrorMessage = "{0} je obavezno")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "{0} mora biti duljine minimalno {2}, a maksimalno {1} znakova")]
        [Display(Name = "Grad/Mjesto")]
        public string Grad { get; set; }

        [Column("postanski_broj")]
        [Required(ErrorMessage = "{0} je obavezno")]
        [Display(Name = "Postanski broj")]
        public int Postanski_broj { get; set; }

        [Column("id_poslovnica")]
        [Required(ErrorMessage = "{0} je obavezno")]
        [Display(Name = "Poslovnica")]
        public PoslovniceEnum Id_poslovnica { get; set; }

        [Column("id_kava")]
        [Required(ErrorMessage = "{0} je obavezno")]
        [Display(Name = "Proizvod")]
        public KavaEnum Id_kava { get; set; }
    }
}