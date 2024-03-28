using ConsoleTools;
using RentMeConsole.Models;
using RentMeConsole.Services;
using System;

namespace RentMeConsole.Views
{
    public class MainView
    {
        private readonly AppSession _session;

        public MainView(AppSession session)
        {
            _session = session;
        }

        public void ShowMenu(string[] args)
        {
            var menu = new ConsoleMenu(args, level: 0)
                .Add("See rental transactions", () => RentalTransactionContext())
                .Add("See rental line items", () => RentalLineItemContext())
                .Add("See return transactions", () => ReturnTransactionContext())
                .Add("See return line items", () => ReturnLineItemContext())
                .Add("See furniture", () => FurnitureContext())
                .Add("Use rental point of service", () => RentalPOSContext())
                .Add("Go back to start menu", ConsoleMenu.Close)
                .Add("Exit", () => Environment.Exit(0))
                .Configure(config =>
                {
                    config.Selector = " -> ";
                    config.EnableFilter = true;
                    config.Title = $"{StyleService.HeadingFormat("Main menu")}";
                    config.EnableWriteTitle = true;
                    config.EnableBreadcrumb = false;
                    config.FilterPrompt = $"{StyleService.PromptFormat("Type here")}";
                });

            menu.Show();
        }

        private void RentalTransactionContext()
        {
            _session.SetContext("rental_transaction");
            NavigationService.Navigate(_session);
        }

        private void RentalLineItemContext()
        {
            _session.SetContext("rental_line_item");
            NavigationService.Navigate(_session);
        }

        private void ReturnTransactionContext()
        {
            _session.SetContext("return_transaction");
            NavigationService.Navigate(_session);
        }

        private void ReturnLineItemContext()
        {
            _session.SetContext("return_line_item");
            NavigationService.Navigate(_session);
        }

        private void FurnitureContext()
        {
            _session.SetContext("furniture");
            NavigationService.Navigate(_session);
        }

        private void RentalPOSContext()
        {
            _session.SetContext("rental_pos");
            NavigationService.Navigate(_session);
        }
    }
}
