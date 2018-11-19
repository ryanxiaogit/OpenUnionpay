using System;
using System.Collections.Generic;
using System.Text;

namespace CoreServices.ServiceObjects.UPOP
{
    public class UPOPRequest
    {
        public virtual string Version { get; set; }
        public virtual string Encoding { get; set; }
        public virtual string CertId { get; set; }
        public virtual string Signature { get; set; }
        public virtual string SignMethod { get; set; }
        public virtual string TxnType { get; set; }
        public virtual string TxnSubType { get; set; }
        public virtual string BizType { get; set; }
        public virtual string AccessType { get; set; }
        public virtual string ChannelType { get; set; }
        public virtual string AcqInsCode { get; set; }
        public virtual string MerId { get; set; }
        public virtual string MerCatCode { get; set; }
        public virtual string MerAbbr { get; set; }
        public virtual string MerName { get; set; }
        public virtual string SubMerId { get; set; }
        public virtual string SubMerName { get; set; }
        public virtual string SubMerAbbr { get; set; }
        public virtual string OrderId { get; set; }
        public virtual string TxnTime { get; set; }
        public virtual int TxnAmt { get; set; }
        public virtual string CurrencyCode { get; set; }
        public virtual string AccNo { get; set; }
        public virtual CustomerInformation CustomerInfo { get; set; }
        public virtual string ReqReserved { get; set; }
        public virtual ReservedField Reserved { get; set; } = new ReservedField();
        public virtual string EncryptyCertId { get; set; }
    }
}
