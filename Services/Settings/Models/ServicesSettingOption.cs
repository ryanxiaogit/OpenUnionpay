using System;
using System.Collections.Generic;
using System.Text;

namespace CoreServices.Settings.Models
{
    public class ServicesSettingOption
    {
        public string SignCertPath { get; set; }
        public string SignCertPassword { get; set; }
        public string EncryptCertPath { get; set; }
        public string MiddleCertPath { get; set; }
        public string RootCertPath { get; set; }
        public string SignMethod { get; set; } = "01";
        public string Version { get; set; } = "5.1.0";
        public string FrontTransUrl { get; set; }
        public string BackTransUrl { get; set; }
        public string QuerUrl { get; set; }
    }
}
