using MVVMDemo.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDemo.MVVM.ViewModels
{
    public class PersonViewModel
    {
        public Person Person { get; set; }
        public PersonViewModel()
        {
            Person = new Person()
            {
                Name = "Alp",
                Age = 22,
                Married = false,
                BirthDate = new DateTime(2000,06,27),
                Weight = 75,
                Lunchtime = new TimeSpan(10,0,0)
            };
        }
    }
}
