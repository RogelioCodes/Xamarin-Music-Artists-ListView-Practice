using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Cells.View;
namespace Cells
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new AlbumView());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
