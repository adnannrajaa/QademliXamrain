using QademliApp.Views.Navigation;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace QademliApp.Views.Forms
{ /// <summary>
  /// Page to login with user name and password
  /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QademliEntryPage : ContentPage
    {
        public QademliEntryPage()
        {
            InitializeComponent();
        }
       public async void SignIn_Clicked(object sender, EventArgs args)
        {
             await Navigation.PushAsync(new NavigationPage(new SimpleLoginPage()));
        }
        public async void SignUp_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NavigationPage(new SimpleSignUpPage()));
        }
        public async void Guest_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new HomePage());
        }
    }
}