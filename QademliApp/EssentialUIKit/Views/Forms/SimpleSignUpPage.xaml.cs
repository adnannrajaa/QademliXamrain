using QademliApp.Views.Navigation;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace QademliApp.Views.Forms
{
    /// <summary>
    /// Page to sign in with user details.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SimpleSignUpPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleSignUpPage" /> class.
        /// </summary>
        public SimpleSignUpPage()
        {
            InitializeComponent();
        }

        public async void SignIn_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new HomePage());
        }
        public async void Register_Clicked(object sender, EventArgs args)
        {
           await DisplayAlert("Button", "Clicked", "ok");
        }
    }
}