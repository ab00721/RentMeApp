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

        /// <summary>
        /// Gets the furniture by ID.
        /// </summary>
        /// <param name="furnitureID">The ID of the furniture.</param>
        /// <returns>The furniture with the specified ID.</returns>
        public Furniture GetFurnitureByID(int furnitureID)
        {
            return _furnitureSource.GetFurnitureByFurnitureID(furnitureID);
        }

        public void DecreaseFurnitureInStockQuantity(int furnitureID, int decreaseBy)
        {
            _furnitureSource.DecreaseFurnitureInStockQuantity(furnitureID, decreaseBy);
        }

        public void IncreaseFurnitureInStockQuantity(int furnitureID, int increaseBy)
        {
            _furnitureSource.IncreaseFurnitureInStockQuantity(furnitureID, increaseBy);
        }
    }
}
