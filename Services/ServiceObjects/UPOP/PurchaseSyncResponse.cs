using System;
using System.Collections.Generic;
using System.Text;

namespace CoreServices.ServiceObjects.UPOP
{
    public class PurchaseSyncResponse : UPOPSyncResponse
    {
        public string QueryId { get; set; }
        public string AccNo { get; set; }
        public string PayCardType { get; set; }
        public string Tn { get; set; }
    }
}
