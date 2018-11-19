using System;
using System.Collections.Generic;
using System.Text;

namespace CoreServices.ServiceObjects.UPOP
{
    public class RefundSyncResponse : UPOPSyncResponse
    {
        public string OrigQryId { get; set; }
        public string QueryId { get; set; }

    }
}
