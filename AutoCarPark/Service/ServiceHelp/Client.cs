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
        public async Task<int> HasBills(Payments payments)
        {
            var convertModel = JsonConvert.SerializeObject(payments);
            var content = new StringContent(convertModel, Encoding.UTF8, "application/json");
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

            var response = await httpClient.PostAsync("https://localhost:44325/api/Payments/payments", content);
            string apiResponse = await response.Content.ReadAsStringAsync();


            if (Convert.ToInt32(apiResponse) != 1)
            {
                return 0;
            }
            else
                return 1;
        }
        public async Task<int> CameraPlate(Logs plate)
        {

            var convertModel = JsonConvert.SerializeObject(plate);
            var content = new StringContent(convertModel, Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("https://localhost:44325/api/Payments/logs", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();

                var result = JsonConvert.DeserializeObject(apiResponse);
                if (Convert.ToBoolean(result) == true)
                {
                    return 1;

                }
                else
                    return 0;


            }
        }
        public async Task<List<Payments>> UnApprovedPayments(int parkid)
        {

            var response = await httpClient.GetAsync("https://localhost:44325/api/Payments/ParkId?ParkId=" + parkid);
            string result = await response.Content.ReadAsStringAsync();
            List<Payments> businessunits = JsonConvert.DeserializeObject<List<Payments>>(result);

            //List<PaymentType> apiResponse = await response.Content.ReadAsStringAsync();

            return businessunits;


        }
        public async Task<int> UserActive(string plate)
        {

            var response = await httpClient.GetAsync("https://localhost:44325/api/Users/getusersactive/" + plate);
            string result = await response.Content.ReadAsStringAsync();
            if (result != "")
            {
                Users businessunits = JsonConvert.DeserializeObject<Users>(result);
                return 1;
            }
            else
                return 0;



        }
        public async Task<int> NewLog(Logs logs)
        {
            var convertModel = JsonConvert.SerializeObject(logs);
            var content = new StringContent(convertModel, Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("https://localhost:44325/api/Logs", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();

                var result = JsonConvert.DeserializeObject(apiResponse);
                if (result == "")
                {
                    return 0;
                }
                else if (Convert.ToBoolean(result) == true)
                {
                    return 1;

                }
                else
                    return 0;


            }
        }

    }
}
