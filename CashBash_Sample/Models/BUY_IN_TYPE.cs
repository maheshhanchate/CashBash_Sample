using System;
using System.Collections.Generic;


namespace CashBash_Sample.Models
{ 
    public partial class BUY_IN_TYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BUY_IN_TYPE()
        {
            this.TRAVELs = new HashSet<TRAVEL>();
            this.TRAVELs1 = new HashSet<TRAVEL>();
            this.TRAVELs2 = new HashSet<TRAVEL>();
            this.TRAVELs3 = new HashSet<TRAVEL>();
        }
    
        public string BUY_IN_TYPE_CD { get; set; }
        public string BUY_IN_TYPE_TX { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRAVEL> TRAVELs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRAVEL> TRAVELs1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRAVEL> TRAVELs2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRAVEL> TRAVELs3 { get; set; }
    }
}
