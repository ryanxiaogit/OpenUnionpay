using System;
using System.Collections.Generic;
using System.Text;

namespace CoreServices.ServiceObjects.UPOP
{
    public class RefundRequest : UPOPRequest
    {
        public string BackUrl { get; set; }
        public string OrigQryId { get; set; }
    }
}
