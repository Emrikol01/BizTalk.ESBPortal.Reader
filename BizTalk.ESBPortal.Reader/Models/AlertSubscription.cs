namespace BizTalk.ESBPortal.Reader
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AlertSubscription")]
    public partial class AlertSubscription
    {
        public Guid AlertSubscriptionID { get; set; }

        public Guid AlertID { get; set; }

        public bool Active { get; set; }

        [Required]
        [StringLength(255)]
        public string Subscriber { get; set; }

        public bool IsGroup { get; set; }

        [StringLength(255)]
        public string CustomEmail { get; set; }

        public bool UseStartAndEndTime { get; set; }

        public byte? StartUTCHour { get; set; }

        public byte? StartUTCMinute { get; set; }

        public byte? EndUTCHour { get; set; }

        public byte? EndUTCMinute { get; set; }

        public DateTime? BlackOutStartDate { get; set; }

        public DateTime? BlackOutEndDate { get; set; }

        public DateTime? LastFired { get; set; }

        public short IntervalMinutes { get; set; }

        public DateTime InsertedDate { get; set; }

        [Required]
        [StringLength(50)]
        public string InsertedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public virtual Alert Alert { get; set; }
    }
}
