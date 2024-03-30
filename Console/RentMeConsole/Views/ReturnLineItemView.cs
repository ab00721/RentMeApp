using ConsoleTools;
using RentMeConsole.Controllers;
using RentMeConsole.Models;
using RentMeConsole.Services;
using System;
using System.Collections.Generic;

namespace RentMeConsole.Views
{
    public class ReturnLineItemView
    {
        private readonly AppSession _session;
        private readonly ReturnLineItemController _returnLineItemController;

        public ReturnLineItemView(AppSession session)
        {
            _session = session;
            _returnLineItemController = new ReturnLineItemController(_session);
        }

        public void ShowMenu(string[] args)
        {
            var menu = new ConsoleMenu(args, level: 0)
                .Add("Display return line items per return transaction", () => DisplayReturnLineItemsByReturnTransaction())
                .Add("Display return line items per rental line item", () => DisplayReturnLineItemsByRentalLineItem())
                .Add("Go back to main menu", ConsoleMenu.Close)
                .Add("Exit", () => Environment.Exit(0))
                .Configure(config =>
                {
                    config.Selector = " -> ";
                    config.EnableFilter = true;
                    config.Title = $"{StyleService.HeadingFormat("Rental line item menu")}";
                    config.EnableWriteTitle = true;
                    config.EnableBreadcrumb = false;
                    config.FilterPrompt = $"{StyleService.PromptFormat("Type here")}";
                });

            menu.Show();
        }

        private void DisplayReturnLineItemsByReturnTransaction()
        {
            int returnTransactionID = GetReturnTransactionIdFromUserInput();

            List<ReturnLineItem> returnLineItems = _returnLineItemController.GetReturnLineItemsByReturnTransactionID(returnTransactionID);
            if (returnLineItems.Count == 0)
            {
                Console.WriteLine($"{StyleService.WarningFormat("No return line items found")}");
                NavigationService.PressAnyKey();
                return;
            }

            Console.WriteLine($"{StyleService.HeadingFormat("Return line items")}");
            Console.WriteLine($"{StyleService.Left("Rnt Line ID", 15)} {StyleService.Left("Rtr ID", 15)} {StyleService.Left("Rtr Trans ID", 15)} {StyleService.Left("Qty", 15)} {StyleService.Left("Daily Cost", 15)}");

            foreach (ReturnLineItem returnLineItem in returnLineItems)
            {
                Console.WriteLine($"{StyleService.Left(returnLineItem.ReturnLineItemID.ToString(), 15)} {StyleService.Left(returnLineItem.RentalLineItemID.ToString(), 15)} {StyleService.Left(returnLineItem.ReturnTransactionID.ToString(), 15)} {StyleService.Left(returnLineItem.Quantity.ToString(), 15)} {StyleService.Left(returnLineItem.DailyCost.ToString(), 15)}");
            }

            NavigationService.PressAnyKey();
        }

        private int GetReturnTransactionIdFromUserInput()
        {
            int returnTransactionID = -1;
            bool isValid = false;

            while (!isValid)
            {
                Console.WriteLine(StyleService.PromptFormat("Enter the return transaction ID:"));
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

        private void DisplayReturnLineItemsByRentalLineItem()
        {
            int rentalLineItemID = GetRentalLineItemIdFromUserInput();

            List<ReturnLineItem> returnLineItems = _returnLineItemController.GetReturnLineItemsByRentalLineItemID(rentalLineItemID);
            if (returnLineItems.Count == 0)
            {
                Console.WriteLine($"{StyleService.WarningFormat("No return line items found")}");
                NavigationService.PressAnyKey();
                return;
            }

            Console.WriteLine($"{StyleService.HeadingFormat("Return line items")}");
            Console.WriteLine($"{StyleService.Left("Return Line ID", 15)} {StyleService.Left("Rental Line ID", 15)} {StyleService.Left("Return Trans ID", 15)} {StyleService.Left("Qty", 15)} {StyleService.Left("Daily Cost", 15)}");

            foreach (ReturnLineItem returnLineItem in returnLineItems)
            {
                Console.WriteLine($"{StyleService.Left(returnLineItem.ReturnLineItemID.ToString(), 15)} {StyleService.Left(returnLineItem.RentalLineItemID.ToString(), 15)} {StyleService.Left(returnLineItem.ReturnTransactionID.ToString(), 15)} {StyleService.Left(returnLineItem.Quantity.ToString(), 15)} {StyleService.Left(returnLineItem.DailyCost.ToString(), 15)}");
            }

            NavigationService.PressAnyKey();
        }

        private int GetRentalLineItemIdFromUserInput()
        {
            int rentalLineItemID = -1;
            bool isValid = false;

            while (!isValid)
            {
                Console.WriteLine(StyleService.PromptFormat("Enter the rental line item ID:"));
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
    }
}
