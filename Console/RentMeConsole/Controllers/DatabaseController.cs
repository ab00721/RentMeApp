using RentMeConsole.DAL;
using RentMeConsole.Models;
using RentMeConsole.Views;

namespace RentMeConsole.Controllers
{
    public class DatabaseController
    {
        private readonly AppSession _session;
        private readonly DatabaseDAL _databaseSource;

        public DatabaseController(AppSession session)
        {
            _session = session;
            _databaseSource = new DatabaseDAL();
        }

        public void DeleteAllTransactions()
        {
            _databaseSource.DeleteAllTransactions();
        }

        public void ShowMenu()
        {
            DatabaseView view = new DatabaseView(_session);
            view.ShowMenu(_session.GetValues());
        }
    }
}
