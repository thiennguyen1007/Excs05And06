using Excs05And06.Models;
using Excs05And06.Services;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Excs05And06.ViewModel
{
    public class MainPageViewModel : BaseViewModel
    {
        private ObservableCollection<NhanVien> _listNhanVien;
        private static NhanVien _nhanVien;

        
        public ObservableCollection<NhanVien> ListNhanVien
        {
            get { return _listNhanVien; }
            set { SetProperty(ref _listNhanVien, value); }
        }
        public NhanVien NhanVien
        {
            get { return _nhanVien; }
            set { SetProperty(ref _nhanVien, value); }
        }
        //=========================================================================================
        public MainPageViewModel()
        {
            LoadNhanVien();
        }
        private void LoadNhanVien()
        {
            ObservableCollection<NhanVien> x=new ObservableCollection<NhanVien>();
            NhanVienService nvService = new NhanVienService();
            x= nvService.DSNhanVien;
            ListNhanVien = x;
        }
        public void LoadDetailPage(NhanVien x)
        {
            Application.Current.MainPage.Navigation.PushAsync(new Views.ChiTietPage(x));
        }
    }
}
