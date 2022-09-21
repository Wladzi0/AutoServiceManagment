using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ApiLibrary
{
    public class ApiProcessor
    {
        public static async Task<MakeModel> LoadBasicCarContent()
        {
            string makeUrl = "https://vpic.nhtsa.dot.gov/api/vehicles/getallmakes?format=json";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(makeUrl))
            {
                if (response.IsSuccessStatusCode)
                {
                    MakeModel makeModel = await response.Content.ReadAsAsync<MakeModel>();

                    return makeModel;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }

        }

    }
}
