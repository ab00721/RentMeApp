using ConsoleTools;
using RentMeConsole.Controllers;
using RentMeConsole.Models;
using RentMeConsole.Services;
using System;
using System.Collections.Generic;

namespace RentMeConsole.Views
{
    public class FurnitureView
    {
        private readonly AppSession _session;
        private readonly FurnitureController _furnitureController;

        public FurnitureView(AppSession session)
        {
            _session = session;
            _furnitureController = new FurnitureController(_session);
        }

        public void ShowMenu(string[] args)
        {
            var menu = new ConsoleMenu(args, level: 0)
                .Add("Display furniture", () => DisplayFurniture())
                .Add("Go back to main menu", ConsoleMenu.Close)
                .Add("Exit", () => Environment.Exit(0))
                .Configure(config =>
                {
                    config.Selector = " -> ";
                    config.EnableFilter = true;
                    config.Title = $"{StyleService.HeadingFormat("Furniture menu")}";
                    config.EnableWriteTitle = true;
                    config.EnableBreadcrumb = false;
                    config.FilterPrompt = $"{StyleService.PromptFormat("Type here")}";
                });

            menu.Show();
        }

        private void DisplayFurniture()
        {
            List<Furniture> items = _furnitureController.GetAllFurniture();
            if (items.Count == 0)
            {
                Console.WriteLine($"{StyleService.WarningFormat("No furniture found")}");
                NavigationService.PressAnyKey();
                return;
            }

            Console.WriteLine($"{StyleService.HeadingFormat("Furniture")}");
            Console.WriteLine($"{StyleService.Left("Furn ID", 10)} {StyleService.Left("Name", 25)} {StyleService.Left("Category", 25)} {StyleService.Left("Style", 25)} {StyleService.Left("Daily Rate", 10)} {StyleService.Left("Total Qty", 10)} {StyleService.Left("Instock Qty", 10)}");

            foreach (var item in items)
            {
                Console.WriteLine($"{StyleService.Left(item.FurnitureID.ToString(), 10)} {StyleService.Left(item.Name, 25)} {StyleService.Left(item.Category.CategoryName, 25)} {StyleService.Left(item.Style.StyleName, 25)} {StyleService.Left(item.DailyRate.ToString("C"), 10)} {StyleService.Left(item.TotalQuantity.ToString(), 10)} {StyleService.Left(item.InStockQuantity.ToString(), 10)}");
            }

            NavigationService.PressAnyKey();
        }
    }
}
