using RentMeConsole.DAL;
using RentMeConsole.Models;
using System.Collections.Generic;

namespace RentMeConsole.Controllers
{
    /// <summary>
    /// The controller class that mediates b/w the FurnitureDAL and the view.
    /// </summary>
    public class FurnitureController
    {
        private readonly FurnitureDAL _furnitureSource;

        /// <summary>
        /// Initializes a new instance of the <see cref="FurnitureController"/> class.
        /// </summary>
        public FurnitureController()
        {
            _furnitureSource = new FurnitureDAL();
        }

        /// <summary>
        /// Returns a list of all furniture items.
        /// </summary>
        public List<Furniture> GetAllFurniture()
        {
            List<Furniture> items = new List<Furniture>();

            foreach (Furniture item in _furnitureSource.GetAllFurniture())
        {
                items.Add(item);
        }

        /// <summary>
        /// Gets the furniture.
        /// </summary>
        /// <param name="searchBy">The search by.</param>
        /// <param name="searchCriteria">The search criteria.</param>
        /// <returns></returns>
        public List<Furniture> GetFurniture(string searchBy, string searchCriteria)
        {
            return this._furnitureSource.GetFurniture(searchBy, searchCriteria);
        }

        }
    }
}
