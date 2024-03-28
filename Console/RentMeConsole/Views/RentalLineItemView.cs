using ConsoleTools;
using RentMeConsole.Controllers;
using RentMeConsole.Models;
using RentMeConsole.Services;
using System;
using System.Collections.Generic;

namespace RentMeConsole.Views
{
    public class RentalLineItemView
    {
        private readonly AppSession _session;
        private readonly RentalLineItemController _rentalLineItemController;

        public RentalLineItemView(AppSession session)
        {
            _session = session;
            _rentalLineItemController = new RentalLineItemController(_session);
        }

        public void ShowMenu(string[] args)
        {
            var menu = new ConsoleMenu(args, level: 0)
                .Add("Display rental line items per rental transaction", () => DisplayRentalLineItems())
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

        private void DisplayRentalLineItems()
        {
            int rentalTransactionID = GetRentalTransactionIdFromUserInput();

            List<RentalLineItem> rentalLineItems = _rentalLineItemController.GetRentalLineItemsByRentalTransactionId(rentalTransactionID);
            if (rentalLineItems.Count == 0)
            {
                Console.WriteLine($"{StyleService.WarningFormat("No rental line items found")}");
                NavigationService.PressAnyKey();
                return;
            }

            Console.WriteLine($"{StyleService.HeadingFormat("Rental line items")}");
            Console.WriteLine($"{StyleService.Left("Line ID", 10)} {StyleService.Left("Trans ID", 10)} {StyleService.Left("Furn ID", 10)} {StyleService.Left("Qty", 10)} {StyleService.Left("Qty Rtn", 10)} {StyleService.Left("Daily Cost", 10)}");

            foreach (RentalLineItem rentalLineItem in rentalLineItems)
            {
                Console.WriteLine($"{StyleService.Left(rentalLineItem.RentalLineItemID.ToString(), 10)} {StyleService.Left(rentalLineItem.RentalTransactionID.ToString(), 10)} {StyleService.Left(rentalLineItem.FurnitureID.ToString(), 10)} {StyleService.Left(rentalLineItem.Quantity.ToString(), 10)} {StyleService.Left(rentalLineItem.QuantityReturned.ToString(), 10)} {StyleService.Left(rentalLineItem.DailyCost.ToString(), 10)}");
            }

            NavigationService.PressAnyKey();
        }

        private int GetRentalTransactionIdFromUserInput()
        {
            int rentalTransactionID = -1;
            bool isValid = false;

            while (!isValid)
            {
                Console.WriteLine(StyleService.PromptFormat("Enter the rental transaction ID:"));
                string input = Console.ReadLine();

                if (int.TryParse(input, out int parsedInt) && parsedInt >= 0 && parsedInt <= 99999)
                {
                    rentalTransactionID = parsedInt;
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

            return rentalTransactionID;
        }
    }
}
