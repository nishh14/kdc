using System;
using System.Collections.Generic;
using CoreGraphics;
using UIKit;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace KensingtonDryCleaners.iOS
{
	public partial class ViewController : UIViewController
	{
		TokenManager tk;
		
		public ViewController(IntPtr handle) : base(handle)
		{




		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			tk = new TokenManager();



			RestManager rs = new RestManager();

			var parameters2 = new Dictionary<string, string> {
						{ "Email", "nishanth916@hotmail.co.uk" },
						{ "Password", "14041991" } };

			String rt = rs.makeRequest("requestToken", parameters2);



			BaseCallObject.RootObject parsedRT = JsonConvert.DeserializeObject<BaseCallObject.RootObject>(rt);
		

			if (tk.retriveSession() == "null" || tk.retriveSession() == "" &&  parsedRT.ReturnObject.SessionID.ToString() != tk.retriveSession())
			{
				tk.createToken(parsedRT.ReturnObject);
			}
			else
			{



				tk.createToken(parsedRT.ReturnObject);



				var parameters3 = new Dictionary<string, string> {
						{ "", "" }};

				//Console.WriteLine(parameters.ToString());


				//	rs.makeRequest("Login", parameters);
				String rk = rs.makeRequest("StoreList", parameters3);



			//	string st2 = JsonConvert.DeserializeObject<Stores.RootObjectStoreDetail>(rk.ReturnObject.ToString()).StoreDetails.ToString();




				//Console.WriteLine(rk);  

				//Console.WriteLine("Hello");

				//var parameters = new Dictionary<string, string> {
				//		{ "EmailAddress", "nishanth916@hotmail.co.uk" },
				//		{ "Password", "22000000" } };

				//Console.WriteLine(parameters.ToString());


				////	rs.makeRequest("Login", parameters);
				//RootObject rk = rs.makeRequest("Login", parameters);
				//Console.WriteLine(rk);

			}


			ScrollableMenu menu = new ScrollableMenu(View);


			View.AddSubview(menu);

		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.		
		}
	}
}
