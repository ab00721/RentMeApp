using ConsoleTools;
using RentMeConsole.Controllers;
using RentMeConsole.Models;
using RentMeConsole.Services;
using System;
using System.Collections.Generic;

namespace RentMeConsole.Views
{
    public class DatabaseView
    {
        private readonly AppSession _session;
        private readonly DatabaseController _databaseController;

        public DatabaseView(AppSession session)
        {
            _session = session;
            _databaseController = new DatabaseController(_session);
        }

        public void ShowMenu(string[] args)
        {
            var menu = new ConsoleMenu(args, level: 0)
                .Add("Delete existing transactions", () => DeleteAllTransactions())
                .Add("Go back to main menu", ConsoleMenu.Close)
                .Add("Exit", () => Environment.Exit(0))
                .Configure(config =>
                {
                    config.Selector = " -> ";
                    config.EnableFilter = true;
                    config.Title = $"{StyleService.HeadingFormat("Database menu")}";
                    config.EnableWriteTitle = true;
                    config.EnableBreadcrumb = false;
                    config.FilterPrompt = $"{StyleService.PromptFormat("Type here")}";
                });

            menu.Show();
        }

        private void DeleteAllTransactions()
        {
            try
            {
                _databaseController.DeleteAllTransactions();
                Console.WriteLine($"{StyleService.SuccessFormat("All transactions deleted successfully")}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{StyleService.WarningFormat("Problem while deleting transactions")}");
                Console.WriteLine($"{StyleService.WarningFormat(e.Message)}");
            }

            NavigationService.PressAnyKey();
        }
    }
}
