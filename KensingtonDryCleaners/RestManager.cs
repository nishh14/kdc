using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using KensingtonDryCleaners.Helpers;
using KensingtonDryCleaners.Helpers.Encoding;
using System.Text;

namespace KensingtonDryCleaners
{
	public class RestManager
	{
		String BaseURL = "https://api.mydrycleaner.com/q";

		String KdcBaseURL = "http://160.153.227.51/server.php?";

		String AccountKey = "UKKENS7610";


		public RestManager()
		{

		}

		public String makeRequest(String request, Dictionary<String,String> Body)
		{
			String ResponseData = null;
			using (var client = new HttpClient())
			{
				if (request == "requestToken")
				{
					client.BaseAddress = new Uri(KdcBaseURL);
					client.DefaultRequestHeaders.Accept.Clear();
					client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
					var response = client.GetAsync("?action=getToken").Result;

					if (response.IsSuccessStatusCode)
					{
						//string responseString = response.Content.ReadAsStringAsync().Result;

						ResponseData = response.Content.ReadAsStringAsync().Result;

						//ResponseData = JsonConvert.DeserializeObject<RootObject>(respo);
					}

				}
				else
				{
					client.BaseAddress = new Uri(BaseURL);
					client.DefaultRequestHeaders.Accept.Clear();
					client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));




					var parameters = new Dictionary<string, string> {
						{ "RequestType", request },
						{ "AccountKey", AccountKey },
						{"SessionID", Settings.SessionID},
						{"Body", System.Text.Encoding.UTF8.EncodeBase64(JsonConvert.SerializeObject(Body))},
						{"UserAgent","IOS"} };


					var content = new StringContent(JsonConvert.SerializeObject(parameters), Encoding.UTF8, "application/json");

					var encodedContent = new FormUrlEncodedContent(parameters);


					var response = client.PostAsync(BaseURL, content).Result;
					if (response.IsSuccessStatusCode)
					{
						//string responseString = response.Content.ReadAsStringAsync().Result;

						ResponseData = response.Content.ReadAsStringAsync().Result;

						//ResponseData = JsonConvert.DeserializeObject<RootObject>(respo);



						//ReturnObject rtt = JsonConvert.DeserializeObject<ReturnObject>(rk2);
					}
					else
					{
						ResponseData = response.Content.ReadAsStringAsync().Result;

						//ResponseData = JsonConvert.DeserializeObject<RootObject>(respo);
					}
				}
			}
			return ResponseData;
		}
	}

}
