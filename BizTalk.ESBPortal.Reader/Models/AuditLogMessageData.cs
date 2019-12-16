namespace BizTalk.ESBPortal.Reader
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AuditLogMessageData")]
    public partial class AuditLogMessageData
    {
        [Key]
        public Guid AuditLogID { get; set; }

        [Required]
        public string MessageData { get; set; }
    }
}
