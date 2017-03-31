using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCSCommon.Models
{
    class Agency
    {       
        public string AgencyCode { get; set; }
        public string AgencyName { get; set; }
        public string ActiveInd { get; set; }
        public string NotAuthorizableInd { get; set; }
        public string EDIEnabledInd { get; set; }
        public string EDI_MIMInd { get; set; }
        public string BillingAgencyCode { get; set; }
        public string RequestCode { get; set; }
        public string GUID { get; set; }
        public string LegalName1 { get; set; }
        public string LegalName2 { get; set; }
        public string LegalName3 { get; set; }
        public string FwAgencyCode { get; set; }
    }
}
