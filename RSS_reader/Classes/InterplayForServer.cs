using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace RSS_reader.Classes
{
    static class InterplayForServer
    {
        //Глобальна переменная пути к серверу
        private const string SERVER_PATH = "http://localhost:29698";
        //Пользователь
        private static User user;

        //регистрация
        public static string Register(string email, string password)
        {
            var registerModel = new
            {
                Email = email,
                Password = password,
                ConfirmPassword = password
            };
            using (var client = new HttpClient())
            {
                var response = client.PostAsJsonAsync(SERVER_PATH + "/api/Account/Register", registerModel).Result;
                return response.StatusCode.ToString();
            }
        }

        //Авторизация
        public static string Authorization(string email, string password)
        {
            user = new User(email, password);
            user.Token = GetTokenDictionary()["access_token"];
            return "OK";
        }

        //Получение токена
        public static Dictionary<string, string> GetTokenDictionary()
        {
            var pairs = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("grant_type", "password"),
                new KeyValuePair<string, string>("username", user.Email),
                new KeyValuePair<string, string>("Password", user.Password)
            };
            var content = new FormUrlEncodedContent(pairs);

            using (var client = new HttpClient())
            {
                var response = client.PostAsync(SERVER_PATH + "/Token", content).Result;
                var result = response.Content.ReadAsStringAsync().Result;
                Dictionary<string, string> tokenDictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(result);
                return tokenDictionary;
            }
        }

        //создание клиента с токеном
        public static HttpClient CreateClient(string accessToken = "")
        {
            var client = new HttpClient();
            if (!string.IsNullOrWhiteSpace(accessToken))
            {
                client.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            }
            return client;
        }

        //получаем информацию о клиенте
        public static string GetUserInfo(string token)
        {
            using (var client = CreateClient(token))
            {
                var response = client.GetAsync(SERVER_PATH + "/api/Account/UserInfo").Result;
                return response.Content.ReadAsStringAsync().Result;
            }
        }

        public static string GetValues(string token)
        {
            using (var client = CreateClient(token))
            {
                var response = client.GetAsync(SERVER_PATH + "/api/values").Result;
                return response.Content.ReadAsStringAsync().Result;
            }
        }
    }


}
