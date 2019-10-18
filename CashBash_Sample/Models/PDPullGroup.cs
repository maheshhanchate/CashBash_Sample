using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class PDPullGroup
    {
        public int PULL_GROUP_ID { get; set; }
        public int EVNT_ID { get; set; }
        public string GROUP_NAME { get; set; }
        public string FWS_DLR_NB { get; set; }
        public string DLR_NM { get; set; }
        public string MASTER_REP_ID { get; set; }
        public string AUTHORIZED_SIGNER_ID { get; set; }
    }
}
