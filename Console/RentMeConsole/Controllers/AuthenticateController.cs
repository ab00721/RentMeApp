using RentMeConsole.DAL;
using RentMeConsole.Models;
using RentMeConsole.Views;

namespace RentMeConsole.Controllers
{
    /// <summary>
    /// The controller class that mediates b/w the AuthenticateDAL and the view.
    /// </summary>
    public class AuthenticateController
    {
        private readonly AppSession _session;
        private readonly AuthenticateDAL _authenticateSource;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticateController"/> class.
        /// </summary>
        public AuthenticateController(AppSession session)
        {
            this._session = session;
            this._authenticateSource = new AuthenticateDAL();
        }

        /// <summary>
        /// Authenticates the specified username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        /// <exception cref="System.Exception"></exception>
        public bool Authenticate(string username, string password)
        {
            return this._authenticateSource.Authenticate(username, password);
        }

        /// <summary>
        /// Adds a new login with the given username and password.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password, which will be hashed.</param>
        public void AddLogin(string username, string password)
        {
            this._authenticateSource.AddLogin(username, password);
        }

        public void ShowMenu()
        {
            AuthenticateView view = new AuthenticateView(_session);
            view.ShowMenu(_session.GetValues());
        }
    }
}
