using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class vwCashBashDealer
    {
        public string FWS_DLR_NB { get; set; }
        public string DLR_NM { get; set; }
        public string DLR_STR_ADDR_TX { get; set; }
        public string DLR_CITY_NM { get; set; }
        public string DLR_ST_CD { get; set; }
        public string DLR_ZIP_CD { get; set; }
        public string DLR_PHN_NB { get; set; }
        public string DLR_FAX_NB { get; set; }
        public string TERR_ZONE_NB { get; set; }
        public string TERR_DIV_NB { get; set; }
        public string TERR_RGN_NB { get; set; }
        public string TERR_DSTT_NB { get; set; }
        public string FLD_REP_NM { get; set; }
        public string LAWSON_VENDOR_ID { get; set; }
        public string TERR_NB { get; set; }
        public int EVNT_ID { get; set; }
        public Nullable<short> PLLS_WON_QY { get; set; }
        public Nullable<short> PLLS_KPT_QY { get; set; }
        public Nullable<short> TRPS_WON_QY { get; set; }
        public string TRPS_PURS_QY { get; set; }
        public Nullable<short> TOTL_PNTS_QY { get; set; }
        public Nullable<int> PULL_ORDR_NB { get; set; }
        public Nullable<System.DateTime> LST_UPDT_DT { get; set; }
        public Nullable<short> PULL_PROGRESS_ID { get; set; }
        public System.DateTime LST_UPDT_TS { get; set; }
        public string PULL_DIST_TYPE { get; set; }
        public string LST_UPDT_USR_ID { get; set; }
    }
}
