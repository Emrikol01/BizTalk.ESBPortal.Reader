namespace BizTalk.ESBPortal.Reader
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserSetting")]
    public partial class UserSetting
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4000)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4000)]
        public string SettingName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(4000)]
        public string SettingValue { get; set; }
    }
}
