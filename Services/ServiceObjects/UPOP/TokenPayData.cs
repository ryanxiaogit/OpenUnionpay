using CoreServices.ServiceObjects.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreServices.ServiceObjects.UPOP
{
    public class TokenPaymentData : DictionaryObject
    {
        public string Token { get => Get("token"); set => Set("token", value); }
        public string TrID { get => Get("trID"); set => Set("trID", value); }
        public string TokenLevel { get => Get("tokenLevel"); set => Set("tokenLevel", value); }
        public string TokenBegin { get => Get("tokenBegin"); set => Set("tokenBegin", value); }
        public string TokenEnd { get => Get("tokenEnd"); set => Set("tokenEnd", value); }
        public string TokenType { get => Get("tokenType"); set => Set("tokenType", value); }

    }
}
