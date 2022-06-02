using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebCoffe.Models
{
    [Table("ovlasti")]
    public class Ovlast
    {
        [Key]
        public string Sifra { get; set; }
        public string Naziv { get; set; }
    }
}