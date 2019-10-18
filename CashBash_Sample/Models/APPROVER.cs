using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{ 
    public partial class APPROVER
    {
        public string APPROVER_ID { get; set; }
        public string FWS_DLR_NB { get; set; }
        public string FRST_NM { get; set; }
        public string LST_NM { get; set; }
        public string EMAIL { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime ModifiedOn { get; set; }
    }
}
