using RentMeConsole.DAL;

namespace RentMeConsole.Models
{
    public class AppSession
    {
        private string _context;
        private RentMeDBConnection _connection;

        public AppSession()
        {
            _context = string.Empty;
            _connection = null;
        }

        public void SetContext(string context)
        {
            _context = context;
        }

        public string GetContext()
        {
            return _context;
        }

        public void SetConnection(RentMeDBConnection connection)
        {
            if (connection != null)
            {
                _connection = connection;
            }
        }

        public RentMeDBConnection GetConnection()
        {
            return _connection;
        }

        public string[] GetValues()
        {
            string[] values = new string[1];
            values[0] = GetContext();
            return values;
        }
    }
}
