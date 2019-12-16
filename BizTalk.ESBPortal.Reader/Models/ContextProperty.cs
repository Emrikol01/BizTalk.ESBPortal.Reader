namespace BizTalk.ESBPortal.Reader
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContextProperty")]
    public partial class ContextProperty
    {
        public Guid ContextPropertyID { get; set; }

        public Guid MessageID { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        [Required]
        [StringLength(4096)]
        public string Value { get; set; }

        [Required]
        [StringLength(256)]
        public string Type { get; set; }

        public DateTime InsertedDate { get; set; }
    }
}
