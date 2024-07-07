using System;
using System.Collections.Generic;

#nullable disable

namespace NowSaiGon.Models
{
    public partial class TblOrderDetail
    {
        public int OdeId { get; set; }
        public int? OrderId { get; set; }
        public int? ProId { get; set; }
        public int? ProDeId { get; set; }
        public string Size { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }

        public virtual TblOrder Order { get; set; }
        public virtual TblProduct Pro { get; set; }
        public virtual TblProductDetail ProDe { get; set; }
    }
}
