using System;
using KensingtonDryCleaners.Helpers;

namespace KensingtonDryCleaners.iOS
{
	public class TokenManager
	{
		public TokenManager()
		{

		}

		public void createToken(BaseCallObject.ReturnObject returnObject)
		{
			if ((returnObject.CustomerID != null) && string.IsNullOrEmpty(returnObject.CustomerID.ToString()))
			{
				Settings.CustomerID = (string)returnObject.CustomerID;

			}
			else
			{
				Settings.CustomerID = string.Empty;
			}

			if (returnObject.CustomerName != null)
			{
				Settings.CustomerName = (string)returnObject.CustomerName;
			}

			if (returnObject.CustomerStoreID != null)
			{
				Settings.CustomerStoreID = (string)returnObject.CustomerStoreID;
			}

			if (returnObject.SessionID != null)
			{
				Settings.SessionID = returnObject.SessionID;
			}
		}

		public BaseCallObject.ReturnObject getToken()
		{
			BaseCallObject.ReturnObject obj = new BaseCallObject.ReturnObject();
			obj.CustomerID = Settings.CustomerID.ToString();
			obj.CustomerName = Settings.CustomerName.ToString();
			obj.CustomerStoreID = Settings.CustomerStoreID.ToString();
			obj.SessionID = Settings.SessionID.ToString().Trim();

			return obj;
		}

		public void updateToken(BaseCallObject.ReturnObject returnObject)
		{
			Settings.CustomerID = returnObject.CustomerID.ToString();
			Settings.CustomerName = returnObject.CustomerName.ToString();
			Settings.CustomerStoreID = returnObject.CustomerStoreID.ToString();
			Settings.SessionID = returnObject.SessionID.ToString().Trim();
		}

		public String retriveSession()
		{
			return Settings.SessionID.ToString().Trim();
		}


	}
}
