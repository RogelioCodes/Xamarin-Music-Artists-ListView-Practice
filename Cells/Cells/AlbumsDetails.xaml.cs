using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cells
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlbumsDetails : ContentPage
    {
        public AlbumsDetails(string AlbumName, string Artist, string ShortDescription, string ImageURL, string ImageURL2 )
        {
            InitializeComponent();
            MyItemNameShow2.Text = Artist;
            MyItemNameShow.Text = AlbumName;
            MyDetailItemShow.Text = ShortDescription;
            MyImageCall.Source = ImageURL;
            MyImageCall2.Source = ImageURL2;

        }
    }
}