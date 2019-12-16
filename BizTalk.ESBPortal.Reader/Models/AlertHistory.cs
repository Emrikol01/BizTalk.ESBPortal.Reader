namespace BizTalk.ESBPortal.Reader
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AlertHistory")]
    public partial class AlertHistory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AlertHistory()
        {
            AlertSubscriptionHistory = new HashSet<AlertSubscriptionHistory>();
        }

        public Guid AlertHistoryID { get; set; }

        [Required]
        [StringLength(255)]
        public string AlertName { get; set; }

        public Guid FaultID { get; set; }

        [Required]
        [StringLength(256)]
        public string Application { get; set; }

        [Required]
        [StringLength(256)]
        public string ServiceName { get; set; }

        public DateTime InsertedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlertSubscriptionHistory> AlertSubscriptionHistory { get; set; }
    }
}
