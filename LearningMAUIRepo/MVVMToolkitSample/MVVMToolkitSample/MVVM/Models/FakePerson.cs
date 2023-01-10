

using CommunityToolkit.Mvvm.ComponentModel;

namespace MVVMToolkitSample.MVVM.Models
{

    public partial class FakePerson : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullName))] //First name updatelenince FullName'i de updateliyor.
        private string firstName;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullName))]
        public string lastName;

        partial void OnFirstNameChanged(string value)
        {
            Console.WriteLine($"{firstName} is registered.");
        }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}