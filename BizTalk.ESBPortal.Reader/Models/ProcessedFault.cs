namespace BizTalk.ESBPortal.Reader
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProcessedFault")]
    public partial class ProcessedFault
    {
        public Guid ProcessedFaultID { get; set; }
    }
}
