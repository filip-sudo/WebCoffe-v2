﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.EntityFramework;
using System.Data.Entity;

namespace WebCoffe.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class web_coffeeDbContext : DbContext
    {
        public DbSet<Kava> PopisKave { get; set; }

        public DbSet<Narudzba> PopisNarudzbi { get; set; }

        public DbSet<Korisnik> PopisKorisnika { get; set; }

        public DbSet<Ovlast> PopisOvlasti { get; set; }

    }
}