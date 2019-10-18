using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class REGISTRATION_IMPORT
    {
        public int ATNE_ID { get; set; }
        public string FRST_NM { get; set; }
        public string LST_NM { get; set; }
        public string TITLE { get; set; }
        public string EMAIL { get; set; }
        public string PARTICIPANT_TYPE { get; set; }
        public string COMPANY { get; set; }
        public string ADDR { get; set; }
        public string ADDR2 { get; set; }
        public string CITY { get; set; }
        public string ST { get; set; }
        public string ZIP { get; set; }
        public string PHONE { get; set; }
        public string SSN { get; set; }
        public string GUEST_FRST_NM { get; set; }
        public string GUEST_LST_NM { get; set; }
        public string ERRORS { get; set; }
        public string WARNINGS { get; set; }
    }
}
