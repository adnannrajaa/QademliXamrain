using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using QademliApp.DataService;

namespace QademliApp.Views.Navigation
{
    /// <summary>
    /// Page to display app usage list.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppUsagePage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppUsagePage" /> class.
        /// </summary>
        public AppUsagePage()
        {
            InitializeComponent();
            this.BindingContext = AppUsageDataService.Instance.AppUsageViewModel;
        }
    }
}