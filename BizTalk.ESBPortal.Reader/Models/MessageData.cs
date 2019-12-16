namespace BizTalk.ESBPortal.Reader
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MessageData")]
    public partial class MessageData
    {
        [Key]
        public Guid MessageID { get; set; }

        [Column("MessageData")]
        [Required]
        public string MessageData1 { get; set; }
    }
}
