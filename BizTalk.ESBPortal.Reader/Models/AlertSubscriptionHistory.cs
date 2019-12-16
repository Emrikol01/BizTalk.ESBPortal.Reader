namespace BizTalk.ESBPortal.Reader
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AlertSubscriptionHistory")]
    public partial class AlertSubscriptionHistory
    {
        public Guid AlertSubscriptionHistoryID { get; set; }

        public Guid AlertHistoryID { get; set; }

        [Required]
        [StringLength(255)]
        public string Subscriber { get; set; }

        public bool IsGroup { get; set; }

        [StringLength(255)]
        public string CustomEmail { get; set; }

        public DateTime InsertedDate { get; set; }

        public virtual AlertHistory AlertHistory { get; set; }
    }
}
