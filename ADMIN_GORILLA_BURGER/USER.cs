namespace ADMIN_GORILLA_BURGER
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USER")]
    public partial class USER
    {
        public int USERID { get; set; }

        [StringLength(20)]
        public string USER_LOGIN { get; set; }

        [StringLength(20)]
        public string USER_PASSWORD { get; set; }

        public int? ROLEID { get; set; }
    }
}
