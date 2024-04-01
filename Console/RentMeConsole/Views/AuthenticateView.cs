using ConsoleTools;
using RentMeConsole.Controllers;
using RentMeConsole.Models;
using RentMeConsole.Services;
using System;
using System.Collections.Generic;

namespace RentMeConsole.Views
{
    public class AuthenticateView
    {
        private readonly AppSession _session;
        private readonly AuthenticateController _authenticateController;

        public AuthenticateView(AppSession session)
        {
            _session = session;
            _authenticateController = new AuthenticateController(_session);
        }

        public void ShowMenu(string[] args)
        {
            var menu = new ConsoleMenu(args, level: 0)
                .Add("Add login", () => AddLogin())
                .Add("Go back to main menu", ConsoleMenu.Close)
                .Add("Exit", () => Environment.Exit(0))
                .Configure(config =>
                {
                    config.Selector = " -> ";
                    config.EnableFilter = true;
                    config.Title = $"{StyleService.HeadingFormat("Authenticate menu")}";
                    config.EnableWriteTitle = true;
                    config.EnableBreadcrumb = false;
                    config.FilterPrompt = $"{StyleService.PromptFormat("Type here")}";
                });

            menu.Show();
        }

        public void AddLogin()
        {
            string username = GetUsernameFromUserInput();
            string password = GetPasswordFromUserInput();

            _authenticateController.AddLogin(username, password);

            NavigationService.PressAnyKey();
        }

        private string GetUsernameFromUserInput()
        {
            string str = string.Empty;
            bool isValid = false;

            while (!isValid)
            {
                Console.WriteLine(StyleService.PromptFormat("Enter the username"));
                string input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {
                    str = input;
                    isValid = true;
                }
                else
                {
                    string message = "Invalid input. Please enter a non-empty string.";
                    Console.WriteLine(StyleService.WarningFormat(message));
                    NavigationService.PressAnyKey();
                }
            }

            return str;
        }

        private string GetPasswordFromUserInput()
        {
            string str = string.Empty;
            bool isValid = false;

            while (!isValid)
            {
                Console.WriteLine(StyleService.PromptFormat("Enter the password (will be hashed)"));
                string input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {
                    str = input;
                    isValid = true;
                }
                else
                {
                    string message = "Invalid input. Please enter a non-empty string.";
                    Console.WriteLine(StyleService.WarningFormat(message));
                    NavigationService.PressAnyKey();
                }
            }

            return str;
        }
    }
}
