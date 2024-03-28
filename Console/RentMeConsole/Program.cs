using RentMeConsole.Models;
using RentMeConsole.Services;

namespace RentMeConsole
{
    public class Program
    {
        static void Main()
        {
            StyleService.AppTitle();
            StyleService.AppInfo();

            NavigationService.PressAnyKey();

            AppSession _session = new AppSession();
            _session.SetContext("main");

            NavigationService.Navigate(_session);
        }
    }
}
