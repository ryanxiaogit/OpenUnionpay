using System;
using System.Collections.Generic;
using System.Text;

namespace CoreServices.ServiceObjects.UPOP
{
    public class UPOPAsyncResponse
    {
        public string Version { get; set; }
        public string Encoding { get; set; }
        public string Signature { get; set; }
        public int SignMethod { get; set; }
        public int TxnType { get; set; }
        public int TxnSubType { get; set; }
        public int BizType { get; set; }
        public int AccessType { get; set; }
        public string AcqInsCode { get; set; }
        public string MerId { get; set; }
        public string OrderId { get; set; }
        public string TxnTime { get; set; }
        public string ReqReserved { get; set; }
        public ReservedField Reserved { get; set; } = new ReservedField();
        public string QueryId { get; set; }
        public string RespCode { get; set; }
        public string RespMsg { get; set; }
        public string SignPubkeyCert { get; set; }
        public string SettleDate { get; set; }
        public string SettleCurrencyCode { get; set; }
        public string SettleAmt { get; set; }
        public double ExchangeRate { get; set; }
        public string ExchangeDate { get; set; }
        public string TraceNo { get; set; }
        public string AccNo { get; set; }
        public string PayCardType { get; set; }
        public string PayCardNo { get; set; }
        public string PayCardIssueNa { get; set; }
        public string CardTransData { get; set; }
        public string SignPubKeyCert { get; set; }
        public string FinancialNetwork { get; set; }
    }
}
