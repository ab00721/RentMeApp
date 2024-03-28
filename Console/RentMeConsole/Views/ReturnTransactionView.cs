using ConsoleTools;
using RentMeConsole.Controllers;
using RentMeConsole.Models;
using RentMeConsole.Services;
using System;
using System.Collections.Generic;

namespace RentMeConsole.Views
{
    public class ReturnTransactionView
    {
        private readonly AppSession _session;
        private readonly ReturnTransactionController _returnTransactionController;

        public ReturnTransactionView(AppSession session)
        {
            _session = session;
            _returnTransactionController = new ReturnTransactionController(_session);
        }

        public void ShowMenu(string[] args)
        {
            var menu = new ConsoleMenu(args, level: 0)
                .Add("Display return transactions", () => DisplayReturnTransactions())
                .Add("Go back to main menu", ConsoleMenu.Close)
                .Add("Exit", () => Environment.Exit(0))
                .Configure(config =>
                {
                    config.Selector = " -> ";
                    config.EnableFilter = true;
                    config.Title = $"{StyleService.HeadingFormat("Return transaction menu")}";
                    config.EnableWriteTitle = true;
                    config.EnableBreadcrumb = false;
                    config.FilterPrompt = $"{StyleService.PromptFormat("Type here")}";
                });

            menu.Show();
        }

        private void DisplayReturnTransactions()
        {
            List<ReturnTransaction> returnTransactions = _returnTransactionController.GetAllReturnTransactions();
            if (returnTransactions.Count == 0)
            {
                Console.WriteLine($"{StyleService.WarningFormat("No rental transactions found")}");
                NavigationService.PressAnyKey();
                return;
            }

            Console.WriteLine($"{StyleService.HeadingFormat("Return transactions")}");
            Console.WriteLine($"{StyleService.Left("Trans ID", 10)} {StyleService.Left("Employee ID", 10)} {StyleService.Left("Member ID", 10)} {StyleService.Left("Return Date", 20)} {StyleService.Left("Total Cost", 15)}");

            foreach (var returnTransaction in returnTransactions)
            {
                Console.WriteLine($"{StyleService.Left(returnTransaction.ReturnTransactionID.ToString(), 10)} {StyleService.Left(returnTransaction.EmployeeID.ToString(), 10)} {StyleService.Left(returnTransaction.MemberID.ToString(), 10)} {StyleService.Left(returnTransaction.ReturnDate.ToString("yyyy-MM-dd HH:mm"), 20)} {StyleService.Left(returnTransaction.TotalCost.ToString("C"), 15)}");
            }

            NavigationService.PressAnyKey();
        }
    }
}
