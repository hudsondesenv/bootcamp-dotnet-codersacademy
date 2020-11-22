using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.Model;

namespace webapi.Repository
{
    public class AlbumRepository
    {
        private MusicContext Context { get; set; }

        public AlbumRepository(MusicContext context)
        {
            this.Context = context;
        }

        public IList<Album> GetAlbumsAsync()
            => this.Context.Albums.ToList();

        
    }
}
