using System;
using System.Collections.Generic;
using System.Text;

namespace CoreServices.ServiceObjects.UPOP
{
    public class UPOPSMSSendingRequest : UPOPRequest
    {
        public override string SignMethod { get => "01"; set => base.SignMethod = value; }
        public override string TxnType { get => "77"; set => base.TxnType = value; }
        public override string BizType { get => "000301"; set => base.BizType = value; }

    }
}
