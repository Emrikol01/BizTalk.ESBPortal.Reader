namespace BizTalk.ESBPortal.Reader
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AlertCondition")]
    public partial class AlertCondition
    {
        public Guid AlertConditionID { get; set; }

        public Guid AlertID { get; set; }

        [Required]
        [StringLength(50)]
        public string LeftSide { get; set; }

        [Required]
        [StringLength(512)]
        public string RightSide { get; set; }

        [Required]
        [StringLength(4)]
        public string Operator { get; set; }

        public DateTime InsertedDate { get; set; }

        public virtual Alert Alert { get; set; }
    }
}
