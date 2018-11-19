using CoreServices.ServiceObjects.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreServices.ServiceObjects.UPOP
{
    public class ReservedField : DictionaryObject
    {
        public string CardNumberLock { get => Get("cardNumberLock"); set => Set("cardNumberLock", value); }
        public string TicketNumber { get => Get("ticketNumber"); set => Set("ticketNumber", value); }
        public string FlightDate { get => Get("flightDate"); set => Set("flightDate", value); }
        public string PageLanguage { get => Get("pageLanguage"); set => Set("pageLanguage", value); }
        public string Vcode { get => Get("vcode"); set => Set("vcode", value); }
        public string Eci { get => Get("eci"); set => Set("eci", value); }
        public string QrcInformation { get => Get("qrcInformation"); set => Set("qrcInformation", value); }
        public string CouponInfo { get => Get("couponInfo"); set => Set("couponInfo", value); }
        public string Discount { get => Get("discount"); set => Set("discount", value); }
        public string OriginalAmount { get => Get("originalAmount"); set => Set("originalAmount", value); }
    }
}
