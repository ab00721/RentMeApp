using ConsoleTools;
using RentMeConsole.Controllers;
using RentMeConsole.Models;
using RentMeConsole.Services;
using System;
using System.Collections.Generic;

namespace RentMeConsole.Views
{
    public class EmployeeView
    {
        private readonly AppSession _session;
        private readonly EmployeeController _employeeController;

        public EmployeeView(AppSession session)
        {
            _session = session;
            _employeeController = new EmployeeController(_session);
        }

        public void ShowMenu(string[] args)
        {
            var menu = new ConsoleMenu(args, level: 0)
                .Add("Display employees", () => DisplayEmployees())
                .Add("Go back to main menu", ConsoleMenu.Close)
                .Add("Exit", () => Environment.Exit(0))
                .Configure(config =>
                {
                    config.Selector = " -> ";
                    config.EnableFilter = true;
                    config.Title = $"{StyleService.HeadingFormat("Employee menu")}";
                    config.EnableWriteTitle = true;
                    config.EnableBreadcrumb = false;
                    config.FilterPrompt = $"{StyleService.PromptFormat("Type here")}";
                });

            menu.Show();
        }

        private void DisplayEmployees()
        {
            List<EmployeeDTO> employees = _employeeController.GetAllEmployees();
            if (employees.Count == 0)
            {
                Console.WriteLine($"{StyleService.WarningFormat("No employee found")}");
                NavigationService.PressAnyKey();
                return;
            }

            Console.WriteLine($"{StyleService.HeadingFormat("Employees")}");
            Console.WriteLine($"{StyleService.Left("Emp ID", 10)} {StyleService.Left("Username", 25)} {StyleService.Left("Last Name", 25)} {StyleService.Left("First Name", 25)} {StyleService.Left("Is Admin", 10)}");

            foreach (var employee in employees)
            {
                Console.WriteLine($"{StyleService.Left(employee.EmployeeID.ToString(), 10)} {StyleService.Left(employee.Username, 25)} {StyleService.Left(employee.LastName, 25)} {StyleService.Left(employee.FirstName, 25)} {StyleService.Left(employee.IsAdmin.ToString(), 10)}");
            }

            NavigationService.PressAnyKey();
        }
    }
}
