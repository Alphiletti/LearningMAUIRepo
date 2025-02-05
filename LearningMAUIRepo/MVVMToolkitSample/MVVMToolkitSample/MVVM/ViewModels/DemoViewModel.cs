﻿using Bogus;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVMToolkitSample.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMToolkitSample.MVVM.ViewModels
{

    public partial class DemoViewModel : ObservableObject
    {
        public FakePerson Person { get; set; }

        [ObservableProperty]
        public string password;

        //public ICommand GenerateData =>
        //     new Command(() =>
        //     {

        //     });

        [RelayCommand]
        async Task GenerateData(string p)
        {
            var faker = new Faker<FakePerson>()
                               .RuleFor(p => p.FirstName, f => f.Person.FirstName)
                               .RuleFor(p => p.LastName, f => f.Person.LastName)
                               .Generate();

            Person.FirstName = faker.FirstName;
            Person.LastName = faker.LastName;

            Password = new Faker().Internet.Password(5, true);
        }

        public DemoViewModel()
        {
            Person = new FakePerson
            {
                FirstName = "Héctor",
                LastName = "Pérez",
            };

            Password = new Faker().Internet.Password(5, true);
        }
    }
}
