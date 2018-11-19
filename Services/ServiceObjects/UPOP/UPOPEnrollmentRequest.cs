using System;
using System.Collections.Generic;
using System.Text;

namespace CoreServices.ServiceObjects.UPOP
{
    public class UPOPEnrollmentRequest : UPOPRequest
    {
        public TokenPaymentData TokenPayData { get; set; }
        public RiskInformation RiskRateInfo { get; set; }
    }
}

