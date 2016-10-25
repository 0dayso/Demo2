using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2Entity
{
    public class HotelSearchRQ
    {
    }
    public class Hotel_Search_RQ
    {
        
        public string Destination { get; set; }

        public string DestinationCode { get; set; }

        public int DestinationCityId { get; set; }

        //ELP use

        public string Selected_RequestID { get; set; }

        public Decimal Selected_Final_Price { get; set; }

        //GTA-DateofChange 11042014
        public string GTA_DestinationCode { get; set; }
        public string GTA_DestinationMultipleCode { get; set; }

        public string CurrentServiceCode { get; set; }
        //EndGTA-DateofChange 

        //LOH-DateofChange 11042014
        public string LOH_DestinationCode { get; set; }
        public string LOH_SequenceNumber { get; set; }
        public bool IsPassengerDetailsRequired { get; set; }

        //EndLOH-DateofChange 

        
        public string Nationality_DOTWCode { get; set; }

        //GTA-DateofChange 14052014
        
        public string Nationality_GTACode { get; set; }
        //EndGTA-DateofChange 


        public string Nationality_LOHCode { get; set; }

        //WTS Properties
        
        public string Nationality_WTSCode { get; set; }
        
        public string CountryOfResidence_WTSCode { get; set; }

        public string WTS_DestinationCode { get; set; }
        public string WTS_DestinationCountry { get; set; }
        public string WTS_SessionNumber { get; set; }
        public string SBR_DestinationCode { get; set; }


        //WTS Properties end

        //GTA-DateofChange 14052014
        public string CountryOfResidence_GTAName { get; set; }
        
        public string CountryOfResidence_GTACode { get; set; }
        //EndGTA-DateofChange 14052014

        // ELP Code
        public string CountryOfResidence_ELPCode { get; set; }
        public string Nationality_ELPCode { get; set; }
        public string ELP_HotelLocation { get; set; }
        // ELP 30-1-2016


        
        public string CountryOfResidence_DOTWCode { get; set; }

        
        public DateTime CheckInDate { get; set; }

        
        public DateTime CheckOutDate { get; set; }
        public Int16 MinimumStay { get; set; }

        
        
        public int Night { get; set; }

        public int SearchId { get; set; }

        public short NumberOfAdult { get; set; }
        public short NumberOfChildren { get; set; }

        
        public string PriceBudget_From { get; set; }

        
        public string PriceBudget_To { get; set; }

        public string ELPSession_Id { get; set; }

        
        // [Remote("ValidateCaptcha", "Home", "Insurance", ErrorMessage = "Captcha Code Mismatch.")]
        public string CaptchaValue { get; set; }

        public short TotalGuests
        {
            get
            {
                return Convert.ToInt16(NumberOfAdult + NumberOfChildren);
            }
        }

        public string PreferedHotelChains { get; set; }
        public string HotelName { get; set; }

        public int Budget { get; set; }
        public bool? roomOnRequest { get; set; }
        public short Rooms { get; set; }
        public string Rating { get; set; }

        public bool PreferredOnly { get; set; }
        public bool AvailableOnly { get; set; }
        public bool AllowLPO { get; set; }

        public List<Room> RoomDetail { get; set; }

        //GTA-DateofChange 11042014
        public string GTA_Selected_DestinationCode { get; set; }
        //EndGTA-DateofChange 
        public string Selected_HotelCode { get; set; }
        public Decimal Selected_TotalAmount { get; set; }
        public Decimal Selected_ServiceFee { get; set; }
        public Decimal Selected_OrginalServiceFee { get; set; }
        public Decimal Selected_PG_ServiceFee { get; set; }
        public Decimal Selected_NetTotal { get; set; }
        public Decimal Selected_OrginalNetTotal { get; set; }
        public Decimal Selected_PriceOrigin { get; set; }

        public Decimal Selected_SubAgentFee { get; set; }
        public Int32 PG_ReceiptId { get; set; }
        public String PG_ReceiptNo { get; set; }
        public String PG_TransactionNo { get; set; }
        public String PG_CreditCardNo { get; set; }
        public Decimal PG_Amount { get; set; }

        public int? PageId { get; set; }

        public Int16 TotalHotels { get; set; }

        public Int32 NewBookingId { get; set; }
        public long NewSuperPNRNo { get; set; }

        public long TRNo { get; set; }

        public bool SendMailForItinerary { get; set; }
        public bool IsTRRequest { get; set; }
        public bool IsEmailSend { get; set; }


        public Decimal Selected_GrossServiceFee { get; set; }
        public Decimal Selected_MarkupFee { get; set; }
        public Decimal Selected_AgencyFee { get; set; }
        public Decimal Selected_AutoDiscount { get; set; }
        public Decimal Selected_ManualDiscount { get; set; }
        public int TripTypeId { get; set; }

        public string HotelCityName { get; set; }

        public decimal minprice { get; set; }
        public decimal maxprice { get; set; }
        public string minpricedescription { get; set; }
        public string maxpricedescription { get; set; }

        public string SabreHotelPNRNo { get; set; }
        //public string SabrePaymentText { get; set; }
        //public string SabreHotelAmountText { get; set; }
        //public string SabreHotelStatus { get; set; }
        //public string SabreHotelPhone { get; set; }
        public string QuotationNo { get; set; }//it assign when book from quotation by sabir

    }
    [Serializable]
    public class Room
    {
        public Hotel_Search_Result HotelDetail { get; set; }
        public Int16 RunNo { get; set; }
        public Int16 NumberOfAdult { get; set; }
        public Int16 NumberOfChild { get; set; }
        public List<Child> ChildList { get; set; }
        public bool IsTwinBed { get; set; }
        public Room_BookingDetail Room_BookingDetail { get; set; }
        //public string WTS_BookingString { get; set; }

        //public Decimal GrossServiceFee { get; set; }
        //public Decimal MarkupFee { get; set; }
        //public Decimal AgencyFee { get; set; }
        //public Decimal AutoDiscount { get; set; }
        //public Decimal ManualDiscount { get; set; }
    }

    [Serializable]
    public class Room_BookingDetail
    {
        public string Selected_RoomTypeCode { get; set; }
        public string Selected_RoomTypeName { get; set; }

        public string Selected_TariffNotes { get; set; }

        public Int16 Selected_RateBasisCode { get; set; }
        public string Selected_RateBasisName { get; set; }
        public Int32 Selected_NoOfNIghts { get; set; }

        public Decimal Selected_RateBasis_Price { get; set; }
        public Decimal Selected_RateBasis_OrginalPrice { get; set; }
        public Decimal Selected_RateBasis_ServiceFee { get; set; }
        public Decimal Selected_RateBasis_OrginalServiceFee { get; set; }
        public Decimal Selected_RateBasis_NetPrice { get; set; }
        public Decimal Selected_RateBasis_OrginalNetPrice { get; set; }

        public string Selected_AllocationDetail { get; set; }
        public bool Selected_IsBlocked { get; set; }

        //GTA-DateofChange 06052014
        public string Confirm_ItemRefrence { get; set; }
        //End GTA-DateofChange 06052014
        public string Confirm_BookingCode { get; set; }
        public string Confirm_BookingReferenceNo { get; set; }
        public bool Confirm_Status { get; set; }
        public string Confirm_Voucher { get; set; }
        public string PaymentGuaranteedBy { get; set; }

        public List<string> CancellationRules;

        public string Selected_WTS_BookingString { get; set; }

        public string SupplierReferenceNumber { get; set; }

        public Decimal Selected_RateBasis_GrossServiceFee { get; set; }
        public Decimal Selected_RateBasis_MarkupFee { get; set; }
        public Decimal Selected_RateBasis_AgencyFee { get; set; }
        public Decimal Selected_RateBasis_AutoDiscount { get; set; }
        public Decimal Selected_RateBasis_ManualDiscount { get; set; }

        // ELP Use
        public string Selected_PackageID { get; set; }

        public string Selected_SabreHotelPNRNo { get; set; }
        public string Selected_SabrePaymentText { get; set; }
        public string Selected_SabreHotelAmountText { get; set; }
        public string Selected_SabreHotelStatus { get; set; }
        public string Selected_SabreHotelPhone { get; set; }

        public DateTime Selected_CheckInDate { get; set; }

        public DateTime Selected_CheckOutDate { get; set; }

        public string Selected_Sabre_Hotel_Currency { get; set; }
        public string Selected_Sabre_Hotel_Amount { get; set; }

    }

    [Serializable]
    public class Child
    {
        public Int16 Age { get; set; }
    }

    [Serializable]
    public class HotelSearchFilter
    {
        public decimal FromPrice { get; set; }
        public decimal ToPrice { get; set; }
        public List<string> HotelChainList { get; set; }
        public List<string> SelectedRating { get; set; }
        public List<string> SelectedPrefered { get; set; }
        public List<string> SelectedSupplier { get; set; }
        public bool IsPreferred { get; set; }
        public bool IsInPolicy { get; set; }
        public bool IsOutPolicy { get; set; }
        public List<string> LocationList { get; set; }

    }

    public class HotelSearchPolicyFilter
    {
        public decimal FromPrice { get; set; }
        public decimal ToPrice { get; set; }
        public int Hotel_Days { get; set; }
        public int Hotel_Rating { get; set; }
        public int Hotel_RefundableOnly { get; set; }
        public string Hotel_Country { get; set; }
        public string Hotel_City { get; set; }
        public decimal Hotel_PerMarginfromlowestfare { get; set; }
        public bool Hotel_Considerinpolicylowestfare { get; set; }
        public decimal Hotel_PerMarginforRoom { get; set; }

        public int ApprovalRuleId;
        public int Preference { get; set; }
    }
}
