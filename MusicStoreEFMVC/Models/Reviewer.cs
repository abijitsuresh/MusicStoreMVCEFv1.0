using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStoreEFMVC.Models
{
    public class Reviewer
    {
        // Many - many
        public int ReviewerID { get; set; }
        public string Name { get; set; }
        public virtual List<Album> Albums { get; set; }

    }
}