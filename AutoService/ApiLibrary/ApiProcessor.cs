using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Windows.Controls;

namespace ApiLibrary
{
    public class ApiProcessor
    {
        public static void LoadBasicCarContent(DataGrid dataGrid)
        {
            string makeUrl = "https://vpic.nhtsa.dot.gov/api/vehicles/decodevinvaluesextended/5UXWX7C5*BA?format=json&modelyear=2011";

            HttpWebRequest request = WebRequest.CreateHttp(makeUrl);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            string responseToString;
            using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
            {
                responseToString = streamReader.ReadToEnd();
            }
            MakeModel make = JsonConvert.DeserializeObject<MakeModel>(responseToString);

            dataGrid.ItemsSource = make.Results;
        }
      
    }
}
