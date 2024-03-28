using RentMeConsole.DAL;
using RentMeConsole.Models;
using RentMeConsole.Views;
using System.Collections.Generic;

namespace RentMeConsole.Controllers
{
    public class FurnitureController
    {
        private readonly AppSession _session;
        private readonly FurnitureDAL _furnitureSource;

        public FurnitureController(AppSession session)
        {
            _session = session;
            _furnitureSource = new FurnitureDAL();
        }

        public List<Furniture> GetAllFurniture()
        {
            List<Furniture> items = new List<Furniture>();

            foreach (Furniture item in _furnitureSource.GetAllFurniture())
            {
                items.Add(item);
            }

            return items;
        }

        public Furniture GetFurnitureByID(int furnitureID)
        {
            return _furnitureSource.GetFurnitureByFurnitureID(furnitureID);
        }

        public void DecreaseFurnitureInStockQuantity(int furnitureID, int decreaseBy)
        {
            _furnitureSource.DecreaseFurnitureInStockQuantity(furnitureID, decreaseBy);
        }

        public void ShowMenu()
        {
            FurnitureView view = new FurnitureView(_session);
            view.ShowMenu(_session.GetValues());
        }
    }
}
