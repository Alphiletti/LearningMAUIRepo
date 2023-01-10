using Bogus;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SQLITEDemo.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SQLITEDemo.MVVM.ViewModels
{
    [ObservableObject]
    public partial class MainPageViewModel
    {
        [ObservableProperty]
        public List<Customer> customers;
        [ObservableProperty]
        public Customer currentCustomer;

        public MainPageViewModel()
        {
            var orders = App.OrdersRepo.GetItems(); // içinde bir şey yok o yüzden debug da count 0
            Refresh();
            GenerateNewCustomer();
        }

        private void GenerateNewCustomer()
        {
            CurrentCustomer = new Faker<Customer>()
                .RuleFor(x => x.Name, f => f.Person.FullName)
                .RuleFor(x => x.Address, f => f.Person.Address.Street)
                .Generate();

            CurrentCustomer.Passport = new List<Passport>
            {
                new Passport
                {
                    ExpirationDate = DateTime.Now.AddDays(30)
                },
                new Passport
                {
                    ExpirationDate = DateTime.Now.AddDays(15)
                },
            };
        }

        [RelayCommand]
        public async void AddOrUpdateX()
        {
            //App.CustomerRepo.SaveItem(CurrentCustomer);
            App.CustomerRepo.SaveItemWithChildren(CurrentCustomer);
            Console.WriteLine(App.CustomerRepo.StatusMessage);
            GenerateNewCustomer();
            Refresh();
        }

        private void Refresh()
        {
            //Customers = App.CustomerRepo.GetItems();
            Customers = App.CustomerRepo.GetItemsWithChildren();
            //Customers = App.CustomerRepo.GetAll(x => x.Name.StartsWith("A"));
            var passports = App.PassportsRepo.GetItems();
        }

        [RelayCommand]
        public void Delete()
        {
            App.CustomerRepo.DeleteItem(CurrentCustomer);
            Refresh();
        }

        
    }
}
