namespace BizTalk.ESBPortal.Reader
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AuditLog")]
    public partial class AuditLog
    {
        public Guid AuditLogID { get; set; }

        public Guid ActionTypeID { get; set; }

        public Guid MessageID { get; set; }

        [StringLength(38)]
        public string NativeMessageID { get; set; }

        [StringLength(50)]
        public string ContentType { get; set; }

        [StringLength(50)]
        public string MessageName { get; set; }

        public Guid? FaultID { get; set; }

        [StringLength(38)]
        public string NativeFaultID { get; set; }

        [StringLength(256)]
        public string Application { get; set; }

        [StringLength(256)]
        public string ServiceName { get; set; }

        [StringLength(512)]
        public string ResubmitURL { get; set; }

        [StringLength(3)]
        public string ResubmitCode { get; set; }

        [StringLength(50)]
        public string ResubmitMessage { get; set; }

        public DateTime AuditDate { get; set; }

        [Required]
        [StringLength(256)]
        public string AuditUserName { get; set; }
    }
}
