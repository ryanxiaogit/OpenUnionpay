using CoreServices.ServiceObjects.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreServices.ServiceObjects.UPOP
{
    public class RiskInformation : DictionaryObject
    {
        public string ShippingFlag { get; set; }
        public string ShipppingCountryCode { get; set; }
        public string ShippingProvinceCode { get; set; }
        public string ShippingCityCode { get; set; }
        public string ShippingDistrictCode { get; set; }
        public string ShippingStreet { get; set; }
        public string ShippingCategory { get; set; }
        public string CommodityCategroy { get; set; }
        public string CommodityName { get; set; }
        public string CommodityUrl { get; set; }
        public string CommodityUnitPrice { get; set; }
        public string CommodityQty { get; set; }
        public string ShippingMobile { get; set; }
        public string AddressModifyTime { get; set; }
        public string UserRegisterTime { get; set; }
        public string UserId { get; set; }
        public string OrderName { get; set; }
        public int UserFlag { get; set; }
        public string MobileModifyTime { get; set; }
        public string MerchantId { get; set; }
        public string MerUserRegDt { get; set; }
        public string MerUserEmail { get; set; }
        public string DiskSep { get; set; }
        public string Imei { get; set; }
        public int DeviceType { get; set; }
        public string CaptureMethod { get; set; }
        public int SimCardCount { get; set; }
        public string DeviceName { get; set; }
    }
}
