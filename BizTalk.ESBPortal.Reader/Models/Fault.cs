namespace BizTalk.ESBPortal.Reader
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Fault")]
    public partial class Fault
    {
        public Guid FaultID { get; set; }

        [StringLength(38)]
        public string NativeMessageID { get; set; }

        [StringLength(38)]
        public string ActivityID { get; set; }

        [Required]
        [StringLength(256)]
        public string Application { get; set; }

        [StringLength(4096)]
        public string Description { get; set; }

        [Required]
        [StringLength(256)]
        public string ErrorType { get; set; }

        [Required]
        [StringLength(256)]
        public string FailureCategory { get; set; }

        [Required]
        [StringLength(20)]
        public string FaultCode { get; set; }

        [StringLength(4096)]
        public string FaultDescription { get; set; }

        public int? FaultSeverity { get; set; }

        [Required]
        [StringLength(256)]
        public string Scope { get; set; }

        [Required]
        [StringLength(38)]
        public string ServiceInstanceID { get; set; }

        [Required]
        [StringLength(256)]
        public string ServiceName { get; set; }

        [StringLength(50)]
        public string FaultGenerator { get; set; }

        [StringLength(256)]
        public string MachineName { get; set; }

        public DateTime? DateTime { get; set; }

        [Required]
        [StringLength(4096)]
        public string ExceptionMessage { get; set; }

        [Required]
        [StringLength(100)]
        public string ExceptionType { get; set; }

        [Required]
        [StringLength(256)]
        public string ExceptionSource { get; set; }

        [Required]
        [StringLength(256)]
        public string ExceptionTargetSite { get; set; }

        [Required]
        [StringLength(4096)]
        public string ExceptionStackTrace { get; set; }

        [Required]
        [StringLength(4096)]
        public string InnerExceptionMessage { get; set; }

        public bool? InsertMessagesFlag { get; set; }

        public DateTime InsertedDate { get; set; }
    }
}
