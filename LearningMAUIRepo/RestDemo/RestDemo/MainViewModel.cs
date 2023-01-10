using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace RestDemo
{
    public partial class MainViewModel
    {
        HttpClient client;
        JsonSerializerOptions _serializerOptions;
        string baseUrl = "https://63664f7e79b0914b75ce1c49.mockapi.io";
        private List<User> Users;

        public MainViewModel()
        {
            client = new HttpClient();
            _serializerOptions = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
        }

        [RelayCommand]
        public async void GetAllUsers()
        {
            var url = $"{baseUrl}/users";
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                //var content = await response.Content.ReadAsStringAsync();
                using(var responseStream = await response.Content.ReadAsStreamAsync())
                {
                    var data = await JsonSerializer.DeserializeAsync<List<User>>(responseStream,_serializerOptions);
                    Users = data;
                }
            } 
        }

        [RelayCommand]
        public async void GetSingleUser(object p)
        {
            var url = $"{baseUrl}/users/{p}";
            var response = await client.GetStringAsync(url);
        }

        [RelayCommand]
        public async void AddUser()
        {
            var url = $"{baseUrl}/users";
            var user = new User
            {
                createdAt = DateTime.Now,
                name = "Alp",
                avatar = "https://fakeimg.pl/350x200/?text=MAUI"
            };

            string json = JsonSerializer.Serialize<User>(user, _serializerOptions);

            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(url, content);
        }

        [RelayCommand]
        public async void UpdateUser()
        {
            var user = Users.FirstOrDefault(x => x.id == "1");

            var url = $"{baseUrl}/users/1";

            user.name = "Test";

            string json = JsonSerializer.Serialize<User>(user, _serializerOptions);

            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PutAsync(url, content);
        }

        [RelayCommand]
        public async void DeleteUser()
        {
            var url = $"{baseUrl}/users/10";
            var response = await client.DeleteAsync(url);

        }
    }
}
