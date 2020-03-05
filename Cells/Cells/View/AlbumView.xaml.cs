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
                DisplayAlert("Hey!", "This app displays a list of Albums! You can click and hold(or just click) on any of the items here to learn more about them or delete them!", "OK");
                counter++;
            }


        }
       
        public void On_More(object sender, System.EventArgs e)
        {
            var mi = ((MenuItem)sender);
            DisplayAlert("More Context Action", mi.CommandParameter + " more context action", "OK");
        }


        public void Remove_Clicked(object sender, EventArgs e) //hold to delete
        {
            
            var mi = sender as MenuItem;
            var album = mi.BindingContext as Album;
            var vm = BindingContext as AlbumViewModel;
            vm.RemoveCommand.Execute(album);
          
        }
        public void Add_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var album = button.BindingContext as Album;
            var vm = BindingContext as AlbumViewModel;
            vm.AddCommand.Execute(album);
        }
        public async void ItemTapped(object sender, ItemTappedEventArgs e) //New page is opened, info about fruit is passed to page
        {
            var mydetails = e.Item as Album;
            await Navigation.PushAsync(new AlbumsDetails(mydetails.AlbumName, mydetails.Artist, mydetails.ShortDescription, mydetails.ImageURL, mydetails.ImageURL2));
        }

        public async void MenuItem_Clicked(object sender, EventArgs e)
        {
            var mi = sender as MenuItem;
            var mydetails = mi.BindingContext as Album;
            var vm = BindingContext as AlbumViewModel;
            await Navigation.PushAsync(new AlbumsDetails(mydetails.AlbumName, mydetails.Artist, mydetails.ShortDescription, mydetails.ImageURL, mydetails.ImageURL2));

        }
    }
}
