namespace BizTalk.ESBPortal.Reader
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Configuration")]
    public partial class Configuration
    {
        public Guid ConfigurationID { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        [StringLength(256)]
        public string Value { get; set; }

        [StringLength(1024)]
        public string Description { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(128)]
        public string ModifiedBy { get; set; }
    }
}
