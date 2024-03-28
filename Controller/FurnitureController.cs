using RentMeApp.DAL;
using RentMeApp.Model;
using System.Collections.Generic;

namespace RentMeApp.Controller
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
        /// Gets all the furniture.
        /// </summary>
        public List<Furniture> GetFurniture()
        {
            return this._furnitureSource.GetFurniture();
        }

        /// <summary>
        /// Gets the furniture.
        /// </summary>
        /// <param name="searchBy">The search by.</param>
        /// <param name="searchCriteria">The search criteria.</param>
        public List<Furniture> GetFurniture(string searchBy, string searchCriteria)
        {
            return this._furnitureSource.GetFurniture(searchBy, searchCriteria);
        }
    }
}
