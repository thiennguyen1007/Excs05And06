
using Excs05And06.Models;
using Excs05And06.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Excs05And06.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChiTietPage : ContentPage
    {
        //private MainPageViewModel data;
        public ChiTietPage(NhanVien x)
        {
            InitializeComponent();
            this.BindingContext = x;
        }
    }
}