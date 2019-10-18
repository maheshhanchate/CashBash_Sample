using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class CHECK_PAYMENTS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHECK_PAYMENTS()
        {
            this.CHECK_PAYMENT_DETAILS = new HashSet<CHECK_PAYMENT_DETAILS>();
        }
    
        public int ID { get; set; }
        public int EVENT_ID { get; set; }
        public string USER_ID { get; set; }
        public System.DateTime CREATED_AT { get; set; }
        public int ETL_STATUS_ID { get; set; }
        public System.DateTime ETL_STATUS_UPDATED_AT { get; set; }
    
        public virtual CASH_BASH_EVENT CASH_BASH_EVENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHECK_PAYMENT_DETAILS> CHECK_PAYMENT_DETAILS { get; set; }
        public virtual ETL_STATUS ETL_STATUS { get; set; }
    }
}
