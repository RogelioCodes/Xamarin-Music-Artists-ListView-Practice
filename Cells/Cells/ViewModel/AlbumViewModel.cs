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
        public Command<Album> AddCommand
        {
            get
            {
                return new Command<Album>((Album) => {
                    Albums.Add(Album);
                });
            }
        }
        public Command<Album> RefreshCommand
        {
            get
            {
                return new Command<Album>((Album) => {
                    Albums.Add(Album);
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
                    ,
                    ImageURL2 = "FKA2.jpg"
                }
                );
                Albums.Add(new Album
                {

                    AlbumName = "Atrocity Exhibition",
                    Artist = "Danny Brown",
                    ImageURL = "atrocity.jpg",
                    ShortDescription = "Atrocity Exhibition is the fourth studio album by American rapper Danny Brown. It was released on September 27, 2016, by Fool's Gold Records and Warp Records." //pulled from google
                    ,
                    ImageURL2 = "atrocity2.jpg"
                }
                );
                Albums.Add(new Album
                {

                    AlbumName = "1000 gecs",
                    Artist = "100 gecs",
                    ImageURL = "gecs.jpg",
                    ShortDescription = "1000 Gecs is the debut studio album by American duo 100 Gecs, released on May 31, 2019 on Dog Show Records. A single from the album, Money Machine, was released on May 29, 2019, two days before the full album was released." //pulled from google
                    ,
                    ImageURL2 = "gecs2.jpg"
                }
               );
                Albums.Add(new Album
                {

                    AlbumName = "Time N Place",
                    Artist = "Kero Kero Bonito",
                    ImageURL = "KKB.jpg",
                    ShortDescription = "Time 'n' Place is the second studio album by British indie pop band Kero Kero Bonito, released on 1 October 2018 through Polyvinyl Record Co. It is their first album released under Polyvinyl. " //pulled from google
                   ,
                    ImageURL2 = "KKB2.jpg"
                }
              );
            };
        }

    }
}
