using System;
using System.Collections.Generic;
using System.Text;

namespace Cells.Model
{
    public class Album
    {
        public string AlbumName { get; set; }
       //public string Genre { get; set; }
        public string Artist { get; set; }
        public string ShortDescription { get; set; }
        public string ImageURL { get; set; }
       public string ImageURL2 { get; set; }
        

        public List<Album> GetAlbums()
        {
            List<Album> albums = new List<Album>()
            {


            };
            return albums;
        }
    }
}
