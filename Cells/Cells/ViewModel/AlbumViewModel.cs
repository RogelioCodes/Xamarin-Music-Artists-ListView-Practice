using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Cells.Model;
using Cells.View;
using Xamarin.Forms;
namespace Cells.ViewModel
{
    public class AlbumViewModel
    {
        public ObservableCollection<Album> Albums { get; set; }
        public Command<Album> RemoveCommand
        {
            get
            {
                return new Command<Album>((Album) => {
                    Albums.Remove(Album);
                });
            }
        }
        public AlbumViewModel()//constructor
        {
            
            Albums = new ObservableCollection<Album>();
            {
                Albums.Add(new Album
                {

                    AlbumName = "LP1",
                    Artist = "FKA TWIGS",
                    ImageURL = "FKA.jpg",
                    ShortDescription = "LP1 is the debut studio album by English singer and songwriter FKA Twigs. It was released on 6 August 2014 by Young Turks. Production for the album is handled by FKA Twigs herself, alongside Emile Haynie, Arca, Cy An, Devonté Hynes, Clams Casino, Paul Epworth, Sampha and Tic. " //pulled from google

                }
                );
                Albums.Add(new Album
                {

                    AlbumName = "Atrocity Exhibition",
                    Artist = "Danny Brown",
                    ImageURL = "atrocity.jpg",
                    ShortDescription = "Atrocity Exhibition is the fourth studio album by American rapper Danny Brown. It was released on September 27, 2016, by Fool's Gold Records and Warp Records." //pulled from google

                }
                );
            };
        }

    }
}
