namespace Deliveroo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DELIVERY_PERSON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DELIVERY_PERSON()
        {
            CLIENT_ORDER = new HashSet<CLIENT_ORDER>();
        }

        public int DELIVERY_PERSONID { get; set; }

        public int? DELIVERY_USERID { get; set; }

        [Required]
        [StringLength(50)]
        public string DELIVERY_PERSON_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string DELIVERY_SURNAME { get; set; }

        [Required]
        [StringLength(80)]
        public string DELIVERY_PERSON_FULL_ADDRESS { get; set; }

        [Required]
        [StringLength(50)]
        public string DELIVERY_PERSON_AREA { get; set; }

        [StringLength(15)]
        public string DELIVERY_PERSON_CONTACTNUMBER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENT_ORDER> CLIENT_ORDER { get; set; }

        public virtual USER USER { get; set; }
    }
}
