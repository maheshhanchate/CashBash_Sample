using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class PDAdminView
    {
        public string TERRITORY { get; set; }
        public string FWS_DLR_NB { get; set; }
        public string DLR_NM { get; set; }
        public int EVNT_ID { get; set; }
        public Nullable<short> PLLS_WON_QY { get; set; }
        public Nullable<short> PLLS_KPT_QY { get; set; }
        public Nullable<short> TRPS_WON_QY { get; set; }
        public string TRPS_PURS_QY { get; set; }
        public Nullable<short> TOTL_PNTS_QY { get; set; }
        public Nullable<System.DateTime> LST_UPDT_DT { get; set; }
        public string PULL_DIST_TYPE { get; set; }
        public string DISPLAY_NM { get; set; }
        public string ENTITY_NAME { get; set; }
        public string APP_USR_ID { get; set; }
        public Nullable<System.DateTime> DATE_APPROVED { get; set; }
        public string FormStatus { get; set; }
    }
}
