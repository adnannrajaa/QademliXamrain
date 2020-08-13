using QademliApp.Views.Navigation;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace QademliApp.Views.Forms
{
    /// <summary>
    /// Page to login with user name and password
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SimpleLoginPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleLoginPage" /> class.
        /// </summary>
        public SimpleLoginPage()
        {
            InitializeComponent();
        }
        public async void Login_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new HomePage());

        }
        public async void SignUp_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new SimpleSignUpPage());

        }
    }
}