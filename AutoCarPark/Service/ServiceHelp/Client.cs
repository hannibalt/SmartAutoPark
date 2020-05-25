using Newtonsoft.Json;
using Service.VMs;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
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
        public async Task<int> LoginRequest(string username, string pass)
        {

            var response = await httpClient.GetAsync("https://localhost:44325/api/Moderators/" + username + "/" + pass);
            string apiResponse = await response.Content.ReadAsStringAsync();
            Moderators moderators = JsonConvert.DeserializeObject<Moderators>(apiResponse);
            if (moderators != null)
            {
                return Convert.ToInt32(moderators.ByParkId);
            }
            else
                return 0;
        }
        public async Task<List<PaymentType>> PaymentTypesRequest()
        {

            var response = await httpClient.GetAsync("https://localhost:44325/api/PaymentType");
            string result = await response.Content.ReadAsStringAsync();
            List<PaymentType> businessunits = JsonConvert.DeserializeObject<List<PaymentType>>(result);

            //List<PaymentType> apiResponse = await response.Content.ReadAsStringAsync();

            return businessunits;
        }

        public async Task<bool> NewUserCreateRequest(Users user)
        {
            var convertModel = JsonConvert.SerializeObject(user);
            var content = new StringContent(convertModel, Encoding.UTF8, "application/json");
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            var response = await httpClient.PostAsync("https://localhost:44325/api/Users", content);
            if (response != null)
            {
                return true;

            }
            else
                return false;

        }


        public async Task<int> CreatePayment(Payments payments)
        {
            var convertModel = JsonConvert.SerializeObject(payments);
            var content = new StringContent(convertModel, Encoding.UTF8, "application/json");
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            var response = await httpClient.PostAsync("https://localhost:44325/api/Payments", content);

            if (response != null)
            {
                return 1;
            }
            else
                return 0;
        }
        public async Task<int> HasAccountRequest(string plate)
        {
            //var convertModel = JsonConvert.SerializeObject(plate);
            //var content = new StringContent(convertModel, Encoding.UTF8, "application/json");
            //httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            var response = await httpClient.GetAsync("https://localhost:44325/api/Users/GetUsersCarPlate/" + plate);
            string apiResponse = await response.Content.ReadAsStringAsync();


            if (apiResponse != "false")
            {
                return 1;
            }
            else
                return 0;
        }
        public async Task<int> HasAccountRequest(Logs plate)
        {
            //var convertModel = JsonConvert.SerializeObject(plate);
            //var content = new StringContent(convertModel, Encoding.UTF8, "application/json");
            //httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            var response = await httpClient.GetAsync("https://localhost:44325/api/Users/GetUsersCarPlate/" + plate);
            string apiResponse = await response.Content.ReadAsStringAsync();


            if (apiResponse != "false")
            {
                return 1;
            }
            else
                return 0;
        }


    }
}
