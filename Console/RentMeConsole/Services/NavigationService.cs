using RentMeConsole.Models;
using RentMeConsole.Controllers;
using System;

namespace RentMeConsole.Services
{
    public static class NavigationService
    {
        public static void Navigate(AppSession _session)
        {
            switch (_session.GetContext())
            {
                case "main":
                    MainController _mainController = new MainController(_session);
                    _mainController.MainMenu();
                    break;

                case "employee":
                    EmployeeController _employeeController = new EmployeeController(_session);
                    _employeeController.ShowMenu();
                    break;

                case "member":
                    MemberController _memberController = new MemberController(_session);
                    _memberController.ShowMenu();
                    break;

                case "rental_transaction":
                    RentalTransactionController _rentalTransactionController = new RentalTransactionController(_session);
                    _rentalTransactionController.ShowMenu();
                    break;

                case "rental_line_item":
                    RentalLineItemController _rentalLineItemController = new RentalLineItemController(_session);
                    _rentalLineItemController.ShowMenu();
                    break;

                case "return_transaction":
                    ReturnTransactionController _returnTransactionController = new ReturnTransactionController(_session);
                    _returnTransactionController.ShowMenu();
                    break;

                case "return_line_item":
                    ReturnLineItemController _returnLineItemController = new ReturnLineItemController(_session);
                    _returnLineItemController.ShowMenu();
                    break;

                case "furniture":
                    FurnitureController _furnitureController = new FurnitureController(_session);
                    _furnitureController.ShowMenu();
                    break;

                case "rental_pos":
                    RentalPointOfSaleService _rentalPointOfSaleService = new RentalPointOfSaleService(_session);
                    _rentalPointOfSaleService.ShowMenu();
                    break;

                case "return_pos":
                    ReturnPointOfSaleService _returnPointOfSaleService = new ReturnPointOfSaleService(_session);
                    _returnPointOfSaleService.ShowMenu();
                    break;

                case "database":
                    DatabaseController _databaseController = new DatabaseController(_session);
                    _databaseController.ShowMenu();
                    break;

                default:
                    _session.SetContext("main");
                    Navigate(_session);
                    break;
            }
        }

        public static void PressAnyKey()
        {
            Console.WriteLine($"{StyleService.YELLOW}Press any key to continue{StyleService.NORMAL}...");
            Console.ReadKey();
        }
    }
}
