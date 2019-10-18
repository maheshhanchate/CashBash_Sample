using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class ETL_STATUS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ETL_STATUS()
        {
            this.CHECK_PAYMENTS = new HashSet<CHECK_PAYMENTS>();
        }
    
        public int ID { get; set; }
        public string NAME { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHECK_PAYMENTS> CHECK_PAYMENTS { get; set; }
    }
}
