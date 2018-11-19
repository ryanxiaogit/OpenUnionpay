using System;
using System.Collections.Generic;
using System.Text;

namespace CoreServices.ServiceObjects.UPOP
{
    public class PurchaseRequest : UPOPRequest
    {
        public string FrontUrl { get; set; }
        public string BackUrl { get; set; }
        public string PayTimeout { get; set; }
        public RiskInformation RiskRateInfo { get; set; } = new RiskInformation();
        public string FrontFailUrl { get; set; }
        public string CustomerIp { get; set; }
        public string TermId { get; set; }
        public string CardTransData { get; set; }
        public string OrderDesc { get; set; }
        public TokenPaymentData TokenPayData { get; set; } = new TokenPaymentData();
    }
}
