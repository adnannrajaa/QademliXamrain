using QademliApp.DataService;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace QademliApp.Views.Navigation
{
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PhotosPage : ContentPage
    {
        public PhotosPage()
        {
            InitializeComponent();

            this.BindingContext = PhotosDataService.Instance.PhotosViewModel;
        }
    }
}