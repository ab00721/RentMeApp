using RentMeApp.DAL;
using RentMeApp.Model;
using System.Collections.Generic;

namespace RentMeApp.Controller
{
    /// <summary>
    /// Controller class for Furniture
    /// </summary>
    public class FurnitureController
    {
        private readonly FurnitureDAL _furnitureSource;

        /// <summary>
        /// Initializes a new instance of the <see cref="FurnitureController"/> class.
        /// </summary>
        public FurnitureController()
        {
            this._furnitureSource = new FurnitureDAL();
        }

        /// <summary>
        /// Gets the furniture.
        /// </summary>
        /// <returns></returns>
        public List<Furniture> GetFurniture()
        {
            return this._furnitureSource.GetFurniture();
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
