using System;
using System.Collections.Generic;
using System.Text;

namespace CoreServices.ServiceObjects.UPOP
{
    public class UPOPSMSSendingResponse : UPOPSyncResponse
    {
        public string AccNo { get; set; }
        public string ActivateStatus { get; set; }
        public string PayCardType { get; set; }
        public CustomerInformation CustomerInfo { get; set; }
        public TokenPaymentData TokenPayData { get; set; }
        public string SignPubKeyCert { get; set; }
    }
}
