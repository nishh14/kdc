using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace KensingtonDryCleaners
{
	public class BaseCallObject
	{
		public BaseCallObject()
		{}

		public class RootObject
		{

			public string Version { get; set; }
			public bool Failed { get; set; }
			public object Message { get; set; }
			public object MessageDetails { get; set; }
			public object ValidationInfo { get; set; }
			public ReturnObject ReturnObject { get; set; }


		}

		public class ReturnObject
		{

			public string SessionID { get; set; }
			public object CustomerID { get; set; }
			public object CustomerName { get; set; }
			public object CustomerStoreName { get; set; }
			public object CustomerStoreID { get; set; }
			public object ExternalID { get; set; }
			public bool IsAr { get; set; }
			public bool IsRoute { get; set; }
			public object PasswordComment { get; set; }
			public object UserAgent { get; set; }
		}
	}




}
