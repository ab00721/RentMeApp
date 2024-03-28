using ConsoleTools;
using RentMeApp.Controller;
using RentMeConsole.Controllers;
using RentMeConsole.Models;
using RentMeConsole.Services;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace RentMeConsole.Views
{
    public class RentalPointOfSaleView
    {
        private readonly AppSession _session;
        private RentalPointOfSaleService _rentalPointOfSaleService;
        private readonly FurnitureController _furnitureController;
        private readonly EmployeeController _employeeController;
        private readonly MemberController _memberController;

        public RentalPointOfSaleView(AppSession session)
        {
            _session = session;
            _rentalPointOfSaleService = new RentalPointOfSaleService(_session);
            _furnitureController = new FurnitureController(_session);
            _employeeController = new EmployeeController();
            _memberController = new MemberController();
        }

        public void ShowMenu(string[] args)
        {
            var subMenu = new ConsoleMenu(args, level: 1)
                .Add("Add rental line items", () => GetRentalLineItemsFromUserInput())
                .Add("See rental line items", () => SeeRentalLineItems())
                .Add("Clear rental cart", () => ClearRentalCart())
                .Add("Finalize rental cart", () => FinalizeRentalCart())
                .Add("Go back to main menu", ConsoleMenu.Close)
                .Configure(config =>
                {
                    config.Selector = " -> ";
                    config.EnableFilter = true;
                    config.Title = $"{StyleService.HeadingFormat("Rental POS submenu")}";
                    config.EnableWriteTitle = true;
                    config.EnableBreadcrumb = false;
                    config.FilterPrompt = $"{StyleService.PromptFormat("Type here")}";
                });

            var menu = new ConsoleMenu(args, level: 0)
                .Add("Record a rental transaction", subMenu.Show)
                .Add("Go back to main menu", ConsoleMenu.Close)
                .Add("Exit", () => Environment.Exit(0))
                .Configure(config =>
                {
                    config.Selector = " -> ";
                    config.EnableFilter = true;
                    config.Title = $"{StyleService.HeadingFormat("Rental POS menu")}";
                    config.EnableWriteTitle = true;
                    config.EnableBreadcrumb = false;
                    config.FilterPrompt = $"{StyleService.PromptFormat("Type here")}";
                });

            menu.Show();
        }

        private void GetRentalLineItemsFromUserInput()
        {
            bool done;
            do
            {
                int furnitureID = GetFurnitureIdFromUserInput();
                int quantity = GetQuantityFromUserInput();

                Furniture furniture = _furnitureController.GetFurnitureByID(furnitureID);
                _rentalPointOfSaleService.AddRentalLineItem(furniture, quantity);

                NavigationService.PressAnyKey();

                done = GetDoneFromUserInput();

            } while (!done);
        }

        private int GetFurnitureIdFromUserInput()
        {
            int furnitureID = -1;
            bool isValid = false;

            while (!isValid)
            {
                Console.WriteLine(StyleService.PromptFormat("Enter the furniture ID"));
                string input = Console.ReadLine();

                if (int.TryParse(input, out int parsedInt) && parsedInt >= 0 && parsedInt <= 99999)
                {
                    furnitureID = parsedInt;
                    isValid = true;
                }
                else
                {
                    string message = "Invalid input. " +
                        "Please enter a number between 0 and 99999 containing only numbers.";
                    Console.WriteLine(StyleService.WarningFormat(message));
                    NavigationService.PressAnyKey();
                }
            }

            return furnitureID;
        }

        private int GetQuantityFromUserInput()
        {
            int quantity = -1;
            bool isValid = false;

            while (!isValid)
            {
                Console.WriteLine(StyleService.PromptFormat("Enter the quantity"));
                string input = Console.ReadLine();

                if (int.TryParse(input, out int parsedInt) && parsedInt >= 0 && parsedInt <= 99999)
                {
                    quantity = parsedInt;
                    isValid = true;
                }
                else
                {
                    string message = "Invalid input. " +
                        "Please enter a number between 0 and 99999 containing only numbers.";
                    Console.WriteLine(StyleService.WarningFormat(message));
                    NavigationService.PressAnyKey();
                }
            }

            return quantity;
        }

        private bool GetDoneFromUserInput()
        {
            while (true)
            {
                Console.WriteLine(StyleService.PromptFormat("Are you done adding items? (Y/N)"));
                string input = Console.ReadLine().ToUpper();

                switch (input)
                {
                    case "Y":
                        return true;
                    case "N":
                        return false;
                    default:
                        string message = "Invalid input. Please enter Y or N.";
                        Console.WriteLine(StyleService.WarningFormat(message));
                        NavigationService.PressAnyKey();
                        break;
                }
            }
        }

        private void SeeRentalLineItems()
        {
            List<RentalLineItem> items = _rentalPointOfSaleService.GetRentalLineItems();
            if (items.Count == 0)
            {
                Console.WriteLine($"{StyleService.WarningFormat("No rental line items found")}");
                NavigationService.PressAnyKey();
                return;
            }

            Console.WriteLine($"{StyleService.HeadingFormat("Rental Line Items")}");
            Console.WriteLine($"{StyleService.Left("Furn ID", 15)} {StyleService.Left("Qty", 15)} {StyleService.Left("Qty Rnt", 15)} {StyleService.Left("Daily Cost", 15)}");

           foreach (var item in items)
            {
                Console.WriteLine($"{StyleService.Left(item.FurnitureID.ToString(), 15)} {StyleService.Left(item.Quantity.ToString(), 15)} {StyleService.Left(item.QuantityReturned.ToString(), 15)} {StyleService.Left(item.DailyCost.ToString("C"), 15)}");
            }

            NavigationService.PressAnyKey();
        }

        private string GetMemberUsernameFromUserInput()
        {
            string username = string.Empty;
            bool isValid = false;

            while (!isValid)
            {
                Console.WriteLine(StyleService.PromptFormat("Enter the member username"));
                string input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {
                    username = input;
                    isValid = true;
                }
                else
                {
                    string message = "Invalid input. Please enter a non-empty username.";
                    Console.WriteLine(StyleService.WarningFormat(message));
                    NavigationService.PressAnyKey();
                }
            }

            return username;
        }

        private Member GetMemberFromUserInput()
        {
            int memberID = GetMemberIDFromUserInput();
            Member member = _memberController.GetMemberByID(memberID);

            if (member == null)
            {
                Console.WriteLine($"{StyleService.WarningFormat("Member not found")}");
                NavigationService.PressAnyKey();
            }

            return member;
        }

        private int GetMemberIDFromUserInput()
        {
            int memberID = -1;
            bool isValid = false;

            while (!isValid)
            {
                Console.WriteLine(StyleService.PromptFormat("Enter the member ID"));
                string input = Console.ReadLine();

                if (int.TryParse(input, out int parsedInt) && parsedInt >= 0 && parsedInt <= 99999)
                {
                    memberID = parsedInt;
                    isValid = true;
                }
                else
                {
                    string message = "Invalid input. " +
                        "Please enter a number between 0 and 99999 containing only numbers.";
                    Console.WriteLine(StyleService.WarningFormat(message));
                    NavigationService.PressAnyKey();
                }
            }

            return memberID;
        }

        private EmployeeDTO GetEmployeeFromUserInput()
        {
            string username = GetEmployeeUsernameFromUserInput();
            EmployeeDTO employee = _employeeController.GetEmployeeByUsername(username);

            if (employee == null)
            {
                Console.WriteLine($"{StyleService.WarningFormat("Employee not found")}");
                NavigationService.PressAnyKey();
            }

            return employee;
        }

        private string GetEmployeeUsernameFromUserInput()
        {
            string username = string.Empty;
            bool isValid = false;

            while (!isValid)
            {
                Console.WriteLine(StyleService.PromptFormat("Enter the employee username"));
                string input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {
                    username = input;
                    isValid = true;
                }
                else
                {
                    string message = "Invalid input. Please enter a non-empty username.";
                    Console.WriteLine(StyleService.WarningFormat(message));
                    NavigationService.PressAnyKey();
                }
            }

            return username;
        }

        private DateTime GetDueDateFromUserInput()
        {
            DateTime dueDate = DateTime.MinValue;
            bool isValid = false;

            while (!isValid)
            {
                Console.WriteLine(StyleService.PromptFormat("Enter the due date (MM/dd/yyyy)"));
                string input = Console.ReadLine();

                if (DateTime.TryParseExact(input, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
                {
                    dueDate = parsedDate;
                    isValid = true;
                }
                else
                {
                    string message = "Invalid input. Please enter a valid date in the format MM/dd/yyyy.";
                    Console.WriteLine(StyleService.WarningFormat(message));
                    NavigationService.PressAnyKey();
                }
            }

            return dueDate;
        }

        private void ClearRentalCart()
        {
            _rentalPointOfSaleService = new RentalPointOfSaleService(_session);
            Console.WriteLine("Rental cart cleared");
            NavigationService.PressAnyKey();
        }

        private void FinalizeRentalCart()
        {
            EmployeeDTO employee = GetEmployeeFromUserInput();
            Member member = GetMemberFromUserInput();
            DateTime dueDate = GetDueDateFromUserInput();

            RentalTransaction rentalTransaction = _rentalPointOfSaleService.CreateRentalTransaction(employee, member, dueDate);

            List<RentalLineItem> lineItems = _rentalPointOfSaleService.GetRentalLineItems();

            _rentalPointOfSaleService.SaveRentalTransaction(rentalTransaction, lineItems);

            ClearRentalCart();
        }
    }
}
