using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2Entity
{
    class HotelSearchResult
    {
    }
    public class Hotel_Search_Result
    {
        //GTA-DateofChange 13052014
        public string ServiceType { get; set; }
        //GTA-DateofChange 13052014
        public Int16 RunNo { get; set; }

        public bool Is_Available { get; set; }
        public bool Is_Preferred { get; set; }
        public int PreferedNo { get; set; }

        public string HotelName { get; set; }
        public string HotelCode { get; set; }
        public string HotelChainCode { get; set; }
        public string HotelChainName { get; set; }
        public string HotelDescription { get; set; }

        public int HotelcityId { get; set; }
        public int HotelcountryId { get; set; }
        public string HotelCityCode { get; set; }
        //GTA-DateofChange 03052014
        public string HotelDestinationCode { get; set; }
        public string OfferLabel { get; set; }
        //End-GTA-DateofChange 03052014
        public string HotelCountryCode { get; set; }

        public Int16 HotelCategory { get; set; }

        public String Address { get; set; }
        public string FirstLocation { get; set; }
        public String Location { get; set; }

        public string Latitude { get; set; }
        public string Longitude { get; set; }

        public string Thumb_Image { get; set; }
        

        public Int16 Distance { get; set; }
        public String DistanceDirection { get; set; }
        public Decimal PriceFrom { get; set; }
        public Decimal OrignalPrice { get; set; }
        public Decimal SubAgentFee { get; set; }
        public Decimal SereviceFee { get; set; }
        public Decimal OrignalSereviceFee { get; set; }


        public String CurrencyCode { get; set; }

        public Dictionary<string, string> AmenitiesList { get; set; }

        

        public string HotelPhone { get; set; }
        //public string  HotelRating { get; set; }

        public Decimal GrossServiceFee { get; set; }
        public Decimal MarkupFee { get; set; }
        public Decimal AgencyFee { get; set; }
        public Decimal AutoDiscount { get; set; }
        public Decimal ManualDiscount { get; set; }

        public int ApprovalRuleId { get; set; }
        public bool Is_InPolicy { get; set; }
        public bool IsHotelQuote { get; set; }
    }
}
