using Excs05And06.Models;
using Excs05And06.ViewModel;
using Xamarin.Forms;

namespace Excs05And06
{
    public partial class MainPage : ContentPage
    {
        private MainPageViewModel data;
        public MainPage()
        {
            InitializeComponent();
            data = new MainPageViewModel();
            this.BindingContext = data;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            
            data.LoadDetailPage(e.SelectedItem as NhanVien);
        }
    }
}
