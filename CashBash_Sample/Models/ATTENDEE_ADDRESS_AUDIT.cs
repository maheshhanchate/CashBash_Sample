using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{ 
    public partial class ATTENDEE_ADDRESS_AUDIT
    {
        public int ATNE_ID { get; set; }
        public string ADDR_LN_1_TX { get; set; }
        public string ADDR_LN_2_TX { get; set; }
        public string ATNE_CITY_NM { get; set; }
        public string ATNE_ST_CD { get; set; }
        public string ATNE_ZIP_CD { get; set; }
        public System.DateTime LST_UPDT_TS { get; set; }
        public string LST_UPDT_USR_ID { get; set; }
        public string UID_IN { get; set; }
    }
}
