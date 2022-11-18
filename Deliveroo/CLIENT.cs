namespace Deliveroo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CLIENT")]
    public partial class CLIENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIENT()
        {
            CLIENT_ORDER = new HashSet<CLIENT_ORDER>();
        }

        public int CLIENTID { get; set; }

        [Required]
        [StringLength(50)]
        public string CLIENT_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string CLIENT_SURNAME { get; set; }

        [StringLength(20)]
        public string CLIENT_LOGIN { get; set; }

        [StringLength(20)]
        public string CLIENT_PASSWORD { get; set; }

        [StringLength(24)]
        public string CLIENT_MAIL { get; set; }

        [Required]
        [StringLength(80)]
        public string CLIENT_FULL_ADDRESS { get; set; }

        [Required]
        [StringLength(50)]
        public string CLIENT_AREA { get; set; }

        [StringLength(15)]
        public string CLIENT_CONTACTNUMBER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENT_ORDER> CLIENT_ORDER { get; set; }
    }
}
