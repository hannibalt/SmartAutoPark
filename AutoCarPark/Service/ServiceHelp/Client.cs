using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using Service.VMs;
using System.Threading.Tasks;

namespace Service.ServiceHelp
{
    public class Client
    {
        private static HttpClient httpClient = new HttpClient();

        public Client()
        {

        }
        //private int ApiHandler(string)
        //{
           
            
            
        //}
        public async Task<int> LoginRequest(string username,string pass) {

            var response = await httpClient.GetAsync("https://localhost:44325/api/Moderators/" + username+"/"+pass);
            string apiResponse = await response.Content.ReadAsStringAsync();
            Moderators moderators = JsonConvert.DeserializeObject<Moderators>(apiResponse);
            if (moderators != null)
            {
                return Convert.ToInt32(moderators.ByParkId);
            }
            else
                return 0;
        }
    }
}
