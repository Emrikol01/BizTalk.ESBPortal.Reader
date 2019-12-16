namespace BizTalk.ESBPortal.Reader
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ActionType")]
    public partial class ActionType
    {
        public Guid ActionTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string ActionName { get; set; }
    }
}
