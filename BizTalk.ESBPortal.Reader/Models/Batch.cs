namespace BizTalk.ESBPortal.Reader
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Batch")]
    public partial class Batch
    {
        public Guid BatchID { get; set; }

        public DateTime StartDatetime { get; set; }

        public DateTime? EndDatetime { get; set; }

        public string ErrorMessage { get; set; }
    }
}
