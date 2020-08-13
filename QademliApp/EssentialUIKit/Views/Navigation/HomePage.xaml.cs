using QademliApp.DataService;
using QademliApp.Views.Feedback;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QademliApp.Views.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            this.BindingContext = NavigationDataService.Instance.NavigationViewModel;

        }
        public async void lvItemTapped(object sender, Syncfusion.ListView.XForms.ItemTappedEventArgs e)
        {
            //var myListView = (SfListView)sender;
            //var myItem = myListView.SelectedItem;
            //await DisplayAlert("Tab", "Item Tab", "Ok");
            await Navigation.PushAsync(new NavigationPage(new ReviewPage()));
        }
    }
}