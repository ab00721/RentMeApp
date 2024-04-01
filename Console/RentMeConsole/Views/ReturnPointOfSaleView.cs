using ConsoleTools;
using RentMeConsole.Controllers;
using RentMeConsole.Models;
using RentMeConsole.Services;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace RentMeConsole.Views
{
    public class ReturnPointOfSaleView
    {
        private readonly AppSession _session;
        private ReturnPointOfSaleService _returnPointOfSaleService;
        private readonly FurnitureController _furnitureController;
        private readonly EmployeeController _employeeController;
        private readonly MemberController _memberController;

        public ReturnPointOfSaleView(AppSession session)
        {
            _session = session;
            _returnPointOfSaleService = new ReturnPointOfSaleService(_session);
            _furnitureController = new FurnitureController(_session);
            _employeeController = new EmployeeController(_session);
            _memberController = new MemberController(_session);
        }

        public void ShowMenu(string[] args)
        {
            var subMenu = new ConsoleMenu(args, level: 1)
                .Add("Add return line items", () => GetReturnLineItemsFromUserInput())
                .Add("See return line items", () => SeeReturnLineItems())
                .Add("Clear return cart", () => ClearReturnCart())
                .Add("Finalize return cart", () => FinalizeReturnCart())
                .Add("Go back to main menu", ConsoleMenu.Close)
                .Configure(config =>
                {
                    config.Selector = " -> ";
                    config.EnableFilter = true;
                    config.Title = $"{StyleService.HeadingFormat("Return POS submenu")}";
                    config.EnableWriteTitle = true;
                    config.EnableBreadcrumb = false;
                    config.FilterPrompt = $"{StyleService.PromptFormat("Type here")}";
                });

            var menu = new ConsoleMenu(args, level: 0)
                .Add("Record a return transaction", subMenu.Show)
                .Add("Display a return transaction confirmation", () => PrintReturnTransactionDetails())
                .Add("Go back to main menu", ConsoleMenu.Close)
                .Add("Exit", () => Environment.Exit(0))
                .Configure(config =>
                {
                    config.Selector = " -> ";
                    config.EnableFilter = true;
                    config.Title = $"{StyleService.HeadingFormat("Return POS menu")}";
                    config.EnableWriteTitle = true;
                    config.EnableBreadcrumb = false;
                    config.FilterPrompt = $"{StyleService.PromptFormat("Type here")}";
                });

            menu.Show();
        }

        private void GetReturnLineItemsFromUserInput()
        {
            bool done;
            do
            {
                int rentalLineItemID = GetRentalLineItemIDFromUserInput();
                int quantity = GetQuantityFromUserInput();

                _returnPointOfSaleService.AddReturnLineItem(rentalLineItemID, quantity);

                NavigationService.PressAnyKey();

                done = GetDoneFromUserInput();

            } while (!done);
        }

        private int GetRentalLineItemIDFromUserInput()
        {
            int rentalLineItemID = -1;
            bool isValid = false;

            while (!isValid)
            {
                Console.WriteLine(StyleService.PromptFormat("Enter the rental line item ID"));
                string input = Console.ReadLine();

                if (int.TryParse(input, out int parsedInt) && parsedInt >= 0 && parsedInt <= 99999)
                {
                    rentalLineItemID = parsedInt;
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

            return rentalLineItemID;
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

        private void SeeReturnLineItems()
        {
            List<ReturnLineItem> items = _returnPointOfSaleService.GetReturnLineItems();
            if (items.Count == 0)
            {
                Console.WriteLine($"{StyleService.WarningFormat("No return line items found")}");
                NavigationService.PressAnyKey();
                return;
            }

            Console.WriteLine($"{StyleService.HeadingFormat("Return Line Items")}");
            Console.WriteLine($"{StyleService.Left("Rnt Ln ID", 15)} {StyleService.Left("Qty", 15)} {StyleService.Left("Daily Cost", 15)}");

            foreach (var item in items)
            {
                Console.WriteLine($"{StyleService.Left(item.RentalLineItemID.ToString(), 15)} {StyleService.Left(item.Quantity.ToString(), 15)} {StyleService.Left(item.DailyCost.ToString("C"), 15)}");
            }

            NavigationService.PressAnyKey();
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

        private void ClearReturnCart()
        {
            _returnPointOfSaleService = new ReturnPointOfSaleService(_session);
            Console.WriteLine("Return cart cleared");
            NavigationService.PressAnyKey();
        }

        private void FinalizeReturnCart()
        {
            EmployeeDTO employee = GetEmployeeFromUserInput();
            Member member = GetMemberFromUserInput();

            ReturnTransaction returnTransaction = _returnPointOfSaleService.CreateReturnTransaction(employee, member);

            List<ReturnLineItem> lineItems = _returnPointOfSaleService.GetReturnLineItems();

            _returnPointOfSaleService.SaveReturnTransaction(returnTransaction, lineItems);

            ClearReturnCart();
        }

        private void PrintReturnTransactionDetails()
        {
            int returnTransactionID = GetReturnTransactionIDFromUserInput();
            Dictionary<ReturnTransaction, List<Tuple<ReturnLineItem, RentalLineItem, Furniture>>> returnTransactionDetails = _returnPointOfSaleService.GetReturnTransactionDetails(returnTransactionID);

            if (returnTransactionDetails.Count == 0)
            {
                Console.WriteLine($"{StyleService.WarningFormat("Return transaction not found")}");
                NavigationService.PressAnyKey();
                return;
            }

            foreach (var kvp in returnTransactionDetails)
            {
                ReturnTransaction returnTransaction = kvp.Key;
                List<Tuple<ReturnLineItem, RentalLineItem, Furniture>> returnLineItems = kvp.Value;

                Console.WriteLine($"{StyleService.HeadingFormat("Return Transaction")}");
                Console.WriteLine($"{StyleService.Left("Trans ID", 15)} {StyleService.Left("Emp ID", 15)} {StyleService.Left("Mem ID", 15)} {StyleService.Left("Rtr Date", 15)} {StyleService.Left("Amt Due", 15)}");
                Console.WriteLine($"{StyleService.Left(returnTransaction.ReturnTransactionID.ToString(), 15)} {StyleService.Left(returnTransaction.EmployeeID.ToString(), 15)} {StyleService.Left(returnTransaction.MemberID.ToString(), 15)} {StyleService.Left(returnTransaction.ReturnDate.ToString("MM/dd/yyyy"), 15)} {StyleService.Left(returnTransaction.TotalCost.ToString("C"), 15)}");

                Console.WriteLine($"{StyleService.HeadingFormat("Return Line Items")}");
                Console.WriteLine($"{StyleService.Left("Line ID", 15)} {StyleService.Left("Rtr Trans ID", 15)} {StyleService.Left("Qty", 15)} {StyleService.Left("Daily Cost", 15)} {StyleService.Left("Rnt ID", 15)} {StyleService.Left("Furn ID", 15)} {StyleService.Left("Furn Name", 15)}");

                foreach (var tuple in returnLineItems)
                {
                    ReturnLineItem returnLineItem = tuple.Item1;
                    RentalLineItem rentalLineItem = tuple.Item2;
                    Furniture furniture = tuple.Item3;

                    Console.WriteLine($"{StyleService.Left(returnLineItem.RentalLineItemID.ToString(), 15)} {StyleService.Left(returnLineItem.ReturnTransactionID.ToString(), 15)} {StyleService.Left(returnLineItem.Quantity.ToString(), 15)} {StyleService.Left(returnLineItem.DailyCost.ToString("C"), 15)} {StyleService.Left(rentalLineItem.RentalTransactionID.ToString(), 15)} {StyleService.Left(furniture.FurnitureID.ToString(), 15)} {StyleService.Left(furniture.Name, 15)}");
                }
            }

            NavigationService.PressAnyKey();
        }

        private int GetReturnTransactionIDFromUserInput()
        {
            int returnTransactionID = -1;
            bool isValid = false;

            while (!isValid)
            {
                Console.WriteLine(StyleService.PromptFormat("Enter the return transaction ID"));
                string input = Console.ReadLine();

                if (int.TryParse(input, out int parsedInt) && parsedInt >= 0 && parsedInt <= 99999)
                {
                    returnTransactionID = parsedInt;
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

            return returnTransactionID;
        }
    }
}
