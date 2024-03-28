using ConsoleTools;
using RentMeConsole.Controllers;
using RentMeConsole.Models;
using RentMeConsole.Services;
using System;
using System.Collections.Generic;

namespace RentMeConsole.Views
{
    public class RentalTransactionView
    {
        private readonly AppSession _session;
        private readonly RentalTransactionController _rentalTransactionController;

        public RentalTransactionView(AppSession session)
        {
            _session = session;
            _rentalTransactionController = new RentalTransactionController(_session);
        }

        public void ShowMenu(string[] args)
        {
            var menu = new ConsoleMenu(args, level: 0)
                .Add("Display rental transactions", () => DisplayRentalTransactions())
                .Add("Go back to main menu", ConsoleMenu.Close)
                .Add("Exit", () => Environment.Exit(0))
                .Configure(config =>
                {
                    config.Selector = " -> ";
                    config.EnableFilter = true;
                    config.Title = $"{StyleService.HeadingFormat("Rental transaction menu")}";
                    config.EnableWriteTitle = true;
                    config.EnableBreadcrumb = false;
                    config.FilterPrompt = $"{StyleService.PromptFormat("Type here")}";
                });

            menu.Show();
        }

        private void DisplayRentalTransactions()
        {
            List<RentalTransaction> rentalTransactions = _rentalTransactionController.GetAllRentalTransactions();
            if (rentalTransactions.Count == 0)
            {
                Console.WriteLine($"{StyleService.WarningFormat("No rental transactions found")}");
                NavigationService.PressAnyKey();
                return;
            }

            Console.WriteLine($"{StyleService.HeadingFormat("Rental transactions")}");
            Console.WriteLine($"{StyleService.Left("Trans ID", 10)} {StyleService.Left("Employee ID", 10)} {StyleService.Left("Member ID", 10)} {StyleService.Left("Rental Date", 20)} {StyleService.Left("Due Date", 20)} {StyleService.Left("Total Cost", 15)}");

            foreach (RentalTransaction rentalTransaction in rentalTransactions)
            {
                Console.WriteLine($"{StyleService.Left(rentalTransaction.RentalTransactionID.ToString(), 10)} {StyleService.Left(rentalTransaction.EmployeeID.ToString(), 10)} {StyleService.Left(rentalTransaction.MemberID.ToString(), 10)} {StyleService.Left(rentalTransaction.RentalDate.ToShortDateString(), 20)} {StyleService.Left(rentalTransaction.DueDate.ToShortDateString(), 20)} {StyleService.Left(rentalTransaction.TotalCost.ToString(), 15)}");
            }

            NavigationService.PressAnyKey();
        }
    }
}
