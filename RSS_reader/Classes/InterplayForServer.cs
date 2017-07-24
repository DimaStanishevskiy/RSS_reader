using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using RSS_reader.Models;

namespace RSS_reader.Classes
{
    static class InterplayForServer
    {
        private const string SERVER_PATH = "http://localhost:5727";
        private static User user;

        static HttpClient CreateClient(string accessToken = "")
        {
            var client = new HttpClient();
            if (!string.IsNullOrWhiteSpace(accessToken))
            {
                client.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            }
            return client;
        }

        #region User 
        public static string Register(string Login, string password)
        {
            var registerModel = new
            {
                Login = Login,
                Password = password
            };
            using (var client = new HttpClient())
            {
                var response = client.PostAsJsonAsync(SERVER_PATH + "/api/login/registration", registerModel).Result;
                return response.StatusCode.ToString();
            }
        }

        public static string Authorization(string Login, string password)
        {
            user = new User(Login, password);
            user.Token = GetTokenDictionary();

            if (user.Token.Length > 0)
            {
                return "OK";
            }
            else return "ERR";
        }

        public static string GetTokenDictionary()
        {
            

            using (var client = new HttpClient())
            {
                var response = client.PostAsJsonAsync(SERVER_PATH + "/api/login/token", user).Result;
                var result = response.Content.ReadAsStringAsync().Result;
                return result;
            }
        }

        public static string Logout()
        {
            user = null;
            return "OK";
        }

        #endregion

        #region Collections
        public static void CreateCollection(string Name)
        {
            Collection collection = new Collection() { Name = Name, Owner = user };
            using (var client = CreateClient(user.Token))
            {
                var response = client.PostAsJsonAsync(SERVER_PATH + "/api/collection/create", collection).Result;
            }
        }
        public static void UpdateCollection(Collection collection)
        {
            using (var client = CreateClient(user.Token))
            {
                var response = client.PostAsJsonAsync(SERVER_PATH + "/api/collection/update", collection).Result;
            }
        }
        public static void DeleteCollection(Collection collection)
        {
            using (var client = CreateClient(user.Token))
            {
                var response = client.PostAsJsonAsync(SERVER_PATH + "/api/collection/delete", collection).Result;
            }
        }
        public static List<Collection> FindCollections()
        {
            using (var client = CreateClient(user.Token))
            {
                var response = client.PostAsJsonAsync(SERVER_PATH + "/api/collection/find", user).Result;
                return response.Content.ReadAsAsync<List<Collection>>().Result;
            }
        }
        #endregion

        #region Collections
        public static void CreateChannel(string Name, string Url, Collection collection)
        {
            Channel channel = new Channel() { Name = Name, Url = Url, Collection = collection};
            using (var client = CreateClient(user.Token))
            {
                var response = client.PostAsJsonAsync(SERVER_PATH + "/api/channel/create", channel).Result;
            }
        }
        public static void UpdateChannel(Channel channel)
        {
            using (var client = CreateClient(user.Token))
            {
                var response = client.PostAsJsonAsync(SERVER_PATH + "/api/channel/update", channel).Result;
            }
        }
        public static void DeleteChannel(Channel channel)
        {
            using (var client = CreateClient(user.Token))
            {
                var response = client.PostAsJsonAsync(SERVER_PATH + "/api/channel/delete", channel).Result;
            }
        }
        public static List<Channel> FindChannels(Collection collection)
        {
            using (var client = CreateClient(user.Token))
            {
                var response = client.PostAsJsonAsync(SERVER_PATH + "/api/channel/find", collection).Result;
                return response.Content.ReadAsAsync<List<Channel>>().Result;
            }
        }

        public static Channel Loadnews(Channel channel)
        {
            using (var client = CreateClient(user.Token))
            {
                var response = client.PostAsJsonAsync(SERVER_PATH + "/api/channel/loadnews", channel).Result;
                channel = response.Content.ReadAsAsync<Channel>().Result;
                return channel;
            }
        }
        #endregion
    }
}
