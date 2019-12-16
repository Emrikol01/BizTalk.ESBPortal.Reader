namespace BizTalk.ESBPortal.Reader
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AlertEmail")]
    public partial class AlertEmail
    {
        public Guid AlertEmailID { get; set; }

        public Guid AlertSubscriptionHistoryID { get; set; }

        [StringLength(256)]
        public string To { get; set; }

        [Required]
        [StringLength(1024)]
        public string Subject { get; set; }

        [Required]
        public string Body { get; set; }

        public bool Sent { get; set; }

        public Guid BatchID { get; set; }

        public DateTime InsertedDate { get; set; }
    }
}
