using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStoreEFMVC.Models.Repositories
{
    public class ArtistRepository : Repository<Artist>
    {
        public List<Artist> GetByName(string name)
        {
            return DbSet.Where(a => a.Name.Contains(name)).ToList();
        }

        public List<SoloArtist> GetSoloArtist()
        {
            return DbSet.OfType<SoloArtist>().ToList();
        }

        public override void Update(Artist entity)
        {
            base.Update(entity);
            SaveChanges();
            entity.version++;
            base.Update(entity);
            SaveChanges();
        }
    }
}