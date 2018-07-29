using System;
using System.Collections.Generic;
using System.Text;

namespace kdc.Models
{
   
    public class Phone
    {
        public string PhoneType { get; set; }
        public string Number { get; set; }
        public string Extension { get; set; }
        public string PhoneMask { get; set; }
    }

    public class PrimaryAddress
    {
        public int AddressTypeID { get; set; }
        public string Addressee { get; set; }
        public string AddressMap { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PostalCodeMask { get; set; }
        public string AddressMapOrLine1 { get; set; }
    }

    public class PrimaryGeoLocation
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

    public class BillingAddress
    {
        public int AddressTypeID { get; set; }
        public string Addressee { get; set; }
        public string AddressMap { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PostalCodeMask { get; set; }
        public string AddressMapOrLine1 { get; set; }
    }

    public class DeliveryAddress
    {
        public int AddressTypeID { get; set; }
        public string Addressee { get; set; }
        public string AddressMap { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PostalCodeMask { get; set; }
        public string AddressMapOrLine1 { get; set; }
    }

    public class DeliveryGeoLocation
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

    public class Notification
    {
        public string NotificationTypeName { get; set; }
        public string NotificationTypeDescription { get; set; }
        public string NotificationMethodName { get; set; }
        public string NotificationMethodDescription { get; set; }
        public bool NotificationValue { get; set; }
    }

    public class CustomerRouteInfo
    {
        public int PickupType { get; set; }
        public int DeliveryType { get; set; }
        public int SundayVisitType { get; set; }
        public int MondayVisitType { get; set; }
        public int TuesdayVisitType { get; set; }
        public int WednesdayVisitType { get; set; }
        public int ThursdayVisitType { get; set; }
        public int FridayVisitType { get; set; }
        public int SaturdayVisitType { get; set; }
        public int PickupAddressType { get; set; }
        public string PickupLocation { get; set; }
        public string PickupInstructions { get; set; }
        public string PickupAdditionalInfo { get; set; }
        public int DeliveryAddressType { get; set; }
        public string DeliveryLocation { get; set; }
        public string DeliveryInstructions { get; set; }
        public string DeliveryAdditionalInfo { get; set; }
        public object PickupAddress1 { get; set; }
        public object PickupAddress2 { get; set; }
        public object PickupCity { get; set; }
        public object PickupState { get; set; }
        public object PickupPostalCode { get; set; }
        public object PickupPostalCodeMask { get; set; }
        public object DeliveryAddress1 { get; set; }
        public object DeliveryAddress2 { get; set; }
        public object DeliveryCity { get; set; }
        public object DeliveryState { get; set; }
        public object DeliveryPostalCode { get; set; }
        public object DeliveryPostalCodeMask { get; set; }
    }

    public class ReturnObject
    {
        public string AccountType { get; set; }
        public string AccountNodeID { get; set; }
        public string StoreName { get; set; }
        public string ClientAccountID { get; set; }
        public string CustomerID { get; set; }
        public string CustomerIDBarcode { get; set; }
        public string CustomerKey { get; set; }
        public string CustomerKeyBarcode { get; set; }
        public string CustomerType { get; set; }
        public string RequestState { get; set; }
        public string Title { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public IList<Phone> Phones { get; set; }
        public PrimaryAddress PrimaryAddress { get; set; }
        public PrimaryGeoLocation PrimaryGeoLocation { get; set; }
        public BillingAddress BillingAddress { get; set; }
        public DeliveryAddress DeliveryAddress { get; set; }
        public DeliveryGeoLocation DeliveryGeoLocation { get; set; }
        public string EmailAddress { get; set; }
        public string EmailAddress2 { get; set; }
        public string EmailAddress3 { get; set; }
        public string EmailAddress4 { get; set; }
        public IList<object> CreditCards { get; set; }
        public DateTime SignupDate { get; set; }
        public object Birthdate { get; set; }
        public IList<object> Preferences { get; set; }
        public IList<object> CustomFields { get; set; }
        public IList<Notification> Notifications { get; set; }
        public string PriceLevel { get; set; }
        public string PriceTable { get; set; }
        public bool IsAR { get; set; }
        public string StatementDestination { get; set; }
        public bool VIPFlag { get; set; }
        public string CurrentRating { get; set; }
        public bool DisableMarketing { get; set; }
        public string CleaningInstructions { get; set; }
        public string FBProgramName { get; set; }
        public string FBProgramType { get; set; }
        public double FBPoints { get; set; }
        public double FBGoal { get; set; }
        public string Locker { get; set; }
        public string LockerPIN { get; set; }
        public int PendingTransactions { get; set; }
        public string ReferralCode { get; set; }
        public string ReferralDetail { get; set; }
        public string ReferralSource { get; set; }
        public int CustomersReferred { get; set; }
        public int CustomersSignedUp { get; set; }
        public bool ShowReferral { get; set; }
        public string MobileInvitationCode { get; set; }
        public double CashCreditBalance { get; set; }
        public string RouteName { get; set; }
        public string RouteID { get; set; }
        public string RouteDays { get; set; }
        public bool UseRouteRules { get; set; }
        public CustomerRouteInfo CustomerRouteInfo { get; set; }
        public double ARBalance { get; set; }
        public double ARBilledCurrent { get; set; }
        public double ARBilled30 { get; set; }
        public double ARBilled60 { get; set; }
        public double ARBilled90 { get; set; }
        public object ACHAccountNumber { get; set; }
        public object ACHRoutingNumber { get; set; }
        public int InProcessOrderCount { get; set; }
        public int ReadyOrderCount { get; set; }
    }

    public class ResponseModel
    {
        public string HostName { get; set; }
        public string Version { get; set; }
        public bool Failed { get; set; }
        public object Message { get; set; }
        public object MessageDetails { get; set; }
        public object ValidationInfo { get; set; }
        public ReturnObject ReturnObject { get; set; }
    }

}
