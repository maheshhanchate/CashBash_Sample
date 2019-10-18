using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class vwAbsentee
    {
        public int EVNT_ID { get; set; }
        public int ATNE_ID { get; set; }
        public string LST_NM { get; set; }
        public string FRST_NM { get; set; }
        public string ATNE_SSN_NB { get; set; }
        public string FWS_DLR_NB { get; set; }
        public string DLR_NM { get; set; }
        public Nullable<int> MSTR_ID { get; set; }
        public Nullable<byte> SPLT_PRGE { get; set; }
    }
}
