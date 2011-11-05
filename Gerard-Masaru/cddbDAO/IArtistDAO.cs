using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cddb.Model;
namespace cddb.cddbDAO
{
    interface IArtistDAO
    {
        List<Artist> listArtists();

    }
}
