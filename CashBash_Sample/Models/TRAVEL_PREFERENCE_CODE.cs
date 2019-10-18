using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class TRAVEL_PREFERENCE_CODE
    {
        public int TRVL_PRFC_ID { get; set; }
        public int EVNT_ID { get; set; }
        public string PRFC_DESC_TX { get; set; }
        public Nullable<System.DateTime> INCE_DT { get; set; }
    }
}
