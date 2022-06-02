﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebCoffe.Models
{
    public class KorisnikPrijava
    {
        [Display(Name = "Korisničko ime")]
        [Required]
        public string KorisnickoIme { get; set; }

        [Display(Name = "Lozinka")]
        [Required]
        [DataType(DataType.Password)]
        public string Lozinka { get; set; }
    }
}