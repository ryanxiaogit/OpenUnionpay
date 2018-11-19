using System;
using System.Collections.Generic;
using System.Text;

namespace CoreServices.ServiceObjects.UPOP
{
    public class RefundAsyncResponse : UPOPAsyncResponse
    {
        public string OrigQryId { get; set; }
        public string CurrencyCode { get; set; }
        public int TxnAmt { get; set; }
        public string TraceTime { get; set; }
    }
}
