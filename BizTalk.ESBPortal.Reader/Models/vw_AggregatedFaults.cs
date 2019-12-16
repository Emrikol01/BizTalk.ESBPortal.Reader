namespace BizTalk.ESBPortal.Reader
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_AggregatedFaults
    {
        public int? FaultCount { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(256)]
        public string Application { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(256)]
        public string ServiceName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(256)]
        public string ErrorType { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string ExceptionType { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string FaultCode { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(256)]
        public string FailureCategory { get; set; }

        public int? FaultSeverity { get; set; }

        public int? Year { get; set; }

        public int? Month { get; set; }

        public int? Day { get; set; }

        public int? Hour { get; set; }

        public DateTime? DateTime { get; set; }

        public DateTime? TrueDateTime { get; set; }
    }
}
