namespace BizTalk.ESBPortal.Reader
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Message")]
    public partial class Message
    {
        public Guid MessageID { get; set; }

        [StringLength(38)]
        public string NativeMessageID { get; set; }

        public Guid FaultID { get; set; }

        [Required]
        [StringLength(50)]
        public string ContentType { get; set; }

        [Required]
        [StringLength(50)]
        public string MessageName { get; set; }

        [StringLength(38)]
        public string InterchangeID { get; set; }

        [StringLength(512)]
        public string RoutingUrl { get; set; }

        public bool ResubmitAttempted { get; set; }

        public bool ResubmitSuccessful { get; set; }

        public DateTime? InsertedDate { get; set; }

        [StringLength(38)]
        public string ActivityID { get; set; }
    }
}
