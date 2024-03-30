using ConsoleTools;
using RentMeConsole.Controllers;
using RentMeConsole.Models;
using RentMeConsole.Services;
using System;
using System.Collections.Generic;

namespace RentMeConsole.Views
{
    public class MemberView
    {
        private readonly AppSession _session;
        private readonly MemberController _memberController;

        public MemberView(AppSession session)
        {
            _session = session;
            _memberController = new MemberController(_session);
        }

        public void ShowMenu(string[] args)
        {
            var menu = new ConsoleMenu(args, level: 0)
                .Add("Display members", () => DisplayMembers())
                .Add("Go back to main menu", ConsoleMenu.Close)
                .Add("Exit", () => Environment.Exit(0))
                .Configure(config =>
                {
                    config.Selector = " -> ";
                    config.EnableFilter = true;
                    config.Title = $"{StyleService.HeadingFormat("Member menu")}";
                    config.EnableWriteTitle = true;
                    config.EnableBreadcrumb = false;
                    config.FilterPrompt = $"{StyleService.PromptFormat("Type here")}";
                });

            menu.Show();
        }

        private void DisplayMembers()
        {
            List<Member> members = _memberController.GetAllMembers();
            if (members.Count == 0)
            {
                Console.WriteLine($"{StyleService.WarningFormat("No member found")}");
                NavigationService.PressAnyKey();
                return;
            }

            Console.WriteLine($"{StyleService.HeadingFormat("Members")}");
            Console.WriteLine($"{StyleService.Left("Emp ID", 10)} {StyleService.Left("Last Name", 25)} {StyleService.Left("First Name", 25)}");

            foreach (var member in members)
            {
                Console.WriteLine($"{StyleService.Left(member.MemberID.ToString(), 10)} {StyleService.Left(member.LastName, 25)} {StyleService.Left(member.FirstName, 25)}");
            }

            NavigationService.PressAnyKey();
        }
    }
}
