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
        public AlbumsDetails(string AlbumName, string Artist, string ShortDescription, string ImageURL )
        {
            InitializeComponent();
            MyItemNameShow.Text = AlbumName;
            MyDetailItemShow.Text = ShortDescription;
            MyImageCall.Source = ImageURL;
           
        }
    }
}