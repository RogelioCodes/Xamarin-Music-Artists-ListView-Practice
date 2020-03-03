using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Cells.Model;
using Cells.View;
using Cells.ViewModel;
namespace Cells.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlbumView : ContentPage
    {
        
        int counter = -1; //used for onAppearing
        public AlbumView()
        {

            InitializeComponent();
            BindingContext = new AlbumViewModel(); //Binding context initialized.

           
            ////////////


        }
        protected override void OnAppearing() //displays prompt when page is opened
        {

            if (counter < 0)
            {
                DisplayAlert("Hey!", "This app displays a list of Albums! You can click on any of the items here to learn more about them.", "OK");
                counter++;
            }


        }

        public async void ItemTapped(object sender, ItemTappedEventArgs e) //New page is opened, info about fruit is passed to page
        {
            var mydetails = e.Item as Album;
            await Navigation.PushAsync(new AlbumsDetails(mydetails.AlbumName, mydetails.Artist, mydetails.ShortDescription, mydetails.ImageURL));
        }
        
    }
}
