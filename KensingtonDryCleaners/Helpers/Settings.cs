using System;
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace KensingtonDryCleaners.Helpers
{
	public static class Settings
	{


		
		private static ISettings AppSettings
		{
			get
			{
				return CrossSettings.Current;
			}

		}

		#region Setting Constants

		private const string customerIDKey = "";
		private static readonly string CustomerIdDefault = string.Empty;

		private const string sessionIDKey = "";
		private static readonly string SessionIDDefault = string.Empty;

		private const string customerStoreIDKey = "";
		private static readonly string CustomerStoreIDDefault = string.Empty;

		private const string customerNameKey = "";
		private static readonly string CustomerNameDefault = string.Empty;


		#endregion


		public static string CustomerID
		{
			get { return AppSettings.GetValueOrDefault<string>(customerIDKey, CustomerIdDefault); }
			set {
					if (!string.IsNullOrWhiteSpace(value))
					{
						AppSettings.AddOrUpdateValue<string>(customerIDKey, value);
					}
					else
					{
						AppSettings.AddOrUpdateValue<string>(customerIDKey, "");
					}
				}
		}

		public static string SessionID
		{
			get { return AppSettings.GetValueOrDefault<string>(sessionIDKey, SessionIDDefault); }
			set
			{

				if (!string.IsNullOrWhiteSpace(value))
				{
					AppSettings.AddOrUpdateValue<string>(sessionIDKey, value);
				}
				else
				{
					AppSettings.AddOrUpdateValue<string>(sessionIDKey, "");
				}
			}
		}

		public static string CustomerStoreID
		{
			get { return AppSettings.GetValueOrDefault<string>(customerStoreIDKey, CustomerStoreIDDefault); }
			set
			{

				if (!string.IsNullOrWhiteSpace(value))
				{
					AppSettings.AddOrUpdateValue<string>(customerStoreIDKey, value);
				}
				else
				{
					AppSettings.AddOrUpdateValue<string>(customerStoreIDKey, "");
				}
			}
		}

		public static string CustomerName
		{
			get { return AppSettings.GetValueOrDefault<string>(customerNameKey, CustomerNameDefault); }
			set
			{

				if (!string.IsNullOrWhiteSpace(value))
				{
					AppSettings.AddOrUpdateValue<string>(customerNameKey, value);
				}
				else
				{
					AppSettings.AddOrUpdateValue<string>(customerNameKey, "");
				}
			}

		}
	}
}
