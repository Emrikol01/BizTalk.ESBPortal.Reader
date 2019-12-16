namespace BizTalk.ESBPortal.Reader
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vwFaultMessageInfo")]
    public partial class vwFaultMessageInfo
    {
        [Key]
        [Column(Order = 0)]
        public Guid MessageID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid FaultID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string ContentType { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string MessageName { get; set; }

        [StringLength(38)]
        public string InterchangeID { get; set; }

        [StringLength(512)]
        public string RoutingUrl { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool ResubmitAttempted { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool ResubmitSuccessful { get; set; }

        public DateTime? MsgInsertDate { get; set; }

        [StringLength(38)]
        public string ActivityID { get; set; }

        [StringLength(38)]
        public string NativeMessageID { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(256)]
        public string Application { get; set; }

        [StringLength(4096)]
        public string Description { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(256)]
        public string ErrorType { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(256)]
        public string FailureCategory { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(20)]
        public string FaultCode { get; set; }

        [StringLength(4096)]
        public string FaultDescription { get; set; }

        public int? FaultSeverity { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(256)]
        public string Scope { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(38)]
        public string ServiceInstanceID { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(256)]
        public string ServiceName { get; set; }

        [StringLength(50)]
        public string FaultGenerator { get; set; }

        [StringLength(256)]
        public string MachineName { get; set; }

        public DateTime? DateTime { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(4096)]
        public string ExceptionMessage { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(100)]
        public string ExceptionType { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(256)]
        public string ExceptionSource { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(256)]
        public string ExceptionTargetSite { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(4096)]
        public string ExceptionStackTrace { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(4096)]
        public string InnerExceptionMessage { get; set; }

        public bool? InsertMessagesFlag { get; set; }

        [Key]
        [Column(Order = 19)]
        public DateTime FaultInsertDate { get; set; }

        [Key]
        [Column(Order = 20)]
        public string MessageData { get; set; }
    }
}
