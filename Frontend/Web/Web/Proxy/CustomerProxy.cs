using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Web.Models;

namespace Web.Proxy
{
    public class CustomerProxy
    {
        public async Task<Customer> GetStudentsAsync()
        {

            var client = new HttpClient();
            var urlBase = "https://localhost:44348";
            client.BaseAddress = new Uri(urlBase);

            var url = string.Concat(urlBase, "/api", "/Student", "/GetAllStudents");
            var response = client.GetAsync(url).Result;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var result = await response.Content.ReadAsStringAsync();
                var students = JsonConvert.DeserializeObject<List<Customer>>(result);

                return new Customer
                {
                   
                };

            }
            else
            {
                return new Customer
                {
                    
                };
            }

        }
    }
}