using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Windows;

namespace ApiLibrary
{
    public class ApiProcessor
    {
        public static void LoadBasicCarContent()
        {
            string makeUrl = "https://vpic.nhtsa.dot.gov/api/vehicles/decodevinvaluesextended/5UXWX7C5*BA?format=json&modelyear=2011";

            HttpWebRequest request = WebRequest.CreateHttp(makeUrl);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            string responseToString;
            using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
            {
                responseToString = streamReader.ReadToEnd();
                
            }
             //JObject obj = JObject.Parse(responseToString);

             //var make = (string)obj.SelectToken("Results[0].Model");
          MakeModel make = JsonConvert.DeserializeObject<MakeModel>(responseToString);

        }
      
    }
}
