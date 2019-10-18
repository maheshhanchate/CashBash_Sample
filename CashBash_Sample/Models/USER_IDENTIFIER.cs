using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class USER_IDENTIFIER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USER_IDENTIFIER()
        {
            this.CASH_BASH_CASH = new HashSet<CASH_BASH_CASH>();
            this.TRAVELs = new HashSet<TRAVEL>();
            this.USER_SECURITY = new HashSet<USER_SECURITY>();
        }
    
        public string USR_ID { get; set; }
        public string FRST_NM { get; set; }
        public string LST_NM { get; set; }
        public string PSWD_TX { get; set; }
        public System.DateTime LST_UPDT_DT { get; set; }
        public string LST_UPDT_USR_ID { get; set; }
        public Nullable<System.DateTime> INCE_DT { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CASH_BASH_CASH> CASH_BASH_CASH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRAVEL> TRAVELs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USER_SECURITY> USER_SECURITY { get; set; }
    }
}
