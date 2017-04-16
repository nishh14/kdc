using System;
namespace KensingtonDryCleaners
{
	public class Stores
	{
		public Stores ()
		{
		}

		public class PhysicalAddress
		{
			public string Address1 { get; set; }
			public string Address2 { get; set; }
			public string City { get; set; }
			public string State { get; set; }
			public string Zip { get; set; }
			public double GeoLatitude { get; set; }
			public double GeoLongitude { get; set; }
			public string Phone { get; set; }
			public string Fax { get; set; }
		}

		public class MapAddress
		{
			public string Address1 { get; set; }
			public string Address2 { get; set; }
			public string City { get; set; }
			public string State { get; set; }
			public string Zip { get; set; }
			public double GeoLatitude { get; set; }
			public double GeoLongitude { get; set; }
			public string Phone { get; set; }
			public string Fax { get; set; }
		}

		public class CustomFields
		{
		}

		public class RootObjectStoreDetail
		{

			public string Version { get; set; }
			public bool Failed { get; set; }
			public object Message { get; set; }
			public object MessageDetails { get; set; }
			public object ValidationInfo { get; set; }
			public StoreDetail StoreDetail { get; set; }	
		s}

		public class StoreDetail
		{
			public string StoreID { get; set; }
			public string StoreName { get; set; }
			public string Mnemonic { get; set; }
			public int Ordinal { get; set; }
			public string HoursOfOperation { get; set; }
			public string ContactName { get; set; }
			public string ContactEmailAddress { get; set; }
			public string Website { get; set; }
			public PhysicalAddress PhysicalAddress { get; set; }
			public MapAddress MapAddress { get; set; }
			public bool HasRoutes { get; set; }
			public bool HasCustomerRoutes { get; set; }
			public bool HasBusinessRoutes { get; set; }
			public CustomFields CustomFields { get; set; }
		}
	}
}
