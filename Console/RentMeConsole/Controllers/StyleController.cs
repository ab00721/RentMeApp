using RentMeConsole.DAL;
using RentMeConsole.Models;
using System.Collections.Generic;

namespace RentMeConsole.Controllers
{
    public class StyleController
    {
        private readonly StyleDAL _styleSource;

        public StyleController()
        {
            _styleSource = new StyleDAL();
        }

        public List<Style> GetAllStyles()
        {
            return _styleSource.GetAllStyles();
        }
    }
}
