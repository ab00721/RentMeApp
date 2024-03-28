using RentMeConsole.Models;
using RentMeConsole.Views;

namespace RentMeConsole.Controllers
{
    public class MainController
    {
        private readonly AppSession _session;

        public MainController(AppSession session)
        {
            _session = session;
        }

        public void MainMenu()
        {
            MainView mainView = new MainView(_session);
            mainView.ShowMenu(_session.GetValues());
        }
    }
}
