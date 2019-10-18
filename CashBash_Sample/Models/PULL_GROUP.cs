using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class PULL_GROUP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PULL_GROUP()
        {
            this.CONTEST_ENTITY = new HashSet<CONTEST_ENTITY>();
            this.ENROLLMENT_GROUP = new HashSet<ENROLLMENT_GROUP>();
        }
    
        public int ID { get; set; }
        public int EVNT_ID { get; set; }
        public string GROUP_NAME { get; set; }
        public string MASTER_DEALER_ID { get; set; }
        public string MASTER_REP_ID { get; set; }
        public string AUTHORIZED_SIGNER_ID { get; set; }
        public int PULL_ASSIGNMENT_TYPE { get; set; }
        public string TERR_NB { get; set; }
        public string REJECT_NOTE { get; set; }
        public Nullable<System.DateTime> APPROVED_REJECTED_AT { get; set; }
    
        public virtual CASH_BASH_EVENT CASH_BASH_EVENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTEST_ENTITY> CONTEST_ENTITY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENROLLMENT_GROUP> ENROLLMENT_GROUP { get; set; }
    }
}
