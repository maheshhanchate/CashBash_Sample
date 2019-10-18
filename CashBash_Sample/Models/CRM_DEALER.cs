using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class CRM_DEALER
    {
        public string FWS_DLR_NB { get; set; }
        public string TERR_NB { get; set; }
        public string TERR_NM { get; set; }
        public string DST_USER_ID { get; set; }
        public string DST_NM { get; set; }
        public string DST_PHONE { get; set; }
        public string DST_EMAIL { get; set; }
        public string RGN_USER_ID { get; set; }
        public string RGN_NM { get; set; }
        public string RGN_PHONE { get; set; }
        public string RGN_EMAIL { get; set; }
        public string DIV_MGR_USER_ID { get; set; }
        public string DIV_MGR_NM { get; set; }
        public string DIV_MGR_PHONE { get; set; }
        public string OWNER_CD { get; set; }
        public string GROUP_NM { get; set; }
        public string DLR_NM { get; set; }
        public string DLR_ADDR { get; set; }
        public string DLR_CITY { get; set; }
        public string DLR_ST_CD { get; set; }
        public string DLR_ZIP { get; set; }
        public string DLR_PHONE { get; set; }
        public string DLR_FAX { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
