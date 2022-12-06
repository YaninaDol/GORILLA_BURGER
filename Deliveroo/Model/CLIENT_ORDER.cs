namespace GORILLA_BURGER
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CLIENT_ORDER
    {
        public DateTime? ORDERTIME { get; set; }

        public int CLIENT_ORDERID { get; set; }

        public int? DELIVERY_PERSONID { get; set; }

        public int? LIST_PRODUCTSID { get; set; }

        public virtual DELIVERY_PERSON DELIVERY_PERSON { get; set; }

        public virtual LIST_PRODUCTS LIST_PRODUCTS { get; set; }
    }
}
