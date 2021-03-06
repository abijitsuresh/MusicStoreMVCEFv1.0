﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MusicStoreEFMVC.Models
{
    public class MusicStoreDataContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }

        public System.Data.Entity.DbSet<MusicStoreEFMVC.Models.ArtistDetails> ArtistDetails { get; set; }
    }
}