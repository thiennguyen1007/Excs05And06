using System.Threading.Tasks;
using Xamarin.Forms;

namespace Excs05And06.Services
{
    public interface IPageService
    {
        Task PushAsync(Page page);
        Task<Page> PopAsync();
        Task<bool> DisplayAlert(string title, string message, string ok, string cancel);
        Task DisplayAlert(string title, string message, string ok);
    }
}
