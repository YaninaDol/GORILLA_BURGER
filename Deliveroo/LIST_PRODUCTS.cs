namespace Deliveroo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LIST_PRODUCTS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LIST_PRODUCTS()
        {
            CLIENT_ORDER = new HashSet<CLIENT_ORDER>();
        }

        public int LIST_PRODUCTSID { get; set; }

        public int? PRODUCTID { get; set; }

        public int COUNT { get; set; }

        public int? USER_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENT_ORDER> CLIENT_ORDER { get; set; }

        public virtual PRODUCT PRODUCT { get; set; }

        public virtual USER USER { get; set; }
    }
}
