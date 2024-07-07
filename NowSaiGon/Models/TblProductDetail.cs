using System;
using System.Collections.Generic;

#nullable disable

namespace NowSaiGon.Models
{
    public partial class TblProductDetail
    {
        public TblProductDetail()
        {
            TblOrderDetails = new HashSet<TblOrderDetail>();
        }

        public int ProDeId { get; set; }
        public int? ProId { get; set; }
        public string Size { get; set; }
        public int? Quantity { get; set; }
        public bool? Published { get; set; }
        public bool? IsNew { get; set; }
        public bool? IsHot { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifierDate { get; set; }
        public string ModifierBy { get; set; }

        public virtual TblProduct Pro { get; set; }
        public virtual ICollection<TblOrderDetail> TblOrderDetails { get; set; }
    }
}
