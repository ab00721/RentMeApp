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
    }
}
