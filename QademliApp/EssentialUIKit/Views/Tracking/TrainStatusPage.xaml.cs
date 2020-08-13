using QademliApp.DataService;
using QademliApp.ViewModels.Tracking;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QademliApp.Views.Tracking
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrainStatusPage : ContentPage
    {
        public TrainStatusPage()
        {
            InitializeComponent();
            this.BindingContext = TrainStatusDataService.Instance.TrainStatusPageViewModel;
            BindableLayout.SetItemsSource(this.trainProgress, (this.BindingContext as TrainStatusPageViewModel).StationInfoCollection);
        }
    }
}