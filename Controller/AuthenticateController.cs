using RentMeApp.DAL;

namespace RentMeApp.Controller
{
    /// <summary>
    /// The controller class that mediates b/w the AuthenticateDAL and the view.
    /// </summary>
    public class AuthenticateController
    {
        private readonly AuthenticateDAL _authenticateSource;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticateController"/> class.
        /// </summary>
        public AuthenticateController()
        {
            _authenticateSource = new AuthenticateDAL();
        }

        /// <summary>
        /// Authenticates the specified username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns>True if the authentication is successful; otherwise, false.<
        public bool Authenticate(string username, string password)
        {
            return _authenticateSource.Authenticate(username, password);
        }

        /// <summary>
        /// Adds a new login with the given username and password.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password, which will be hashed.</param>
        public void AddLogin(string username, string password)
        {
            _authenticateSource.AddLogin(username, password);
        }
    }
}
