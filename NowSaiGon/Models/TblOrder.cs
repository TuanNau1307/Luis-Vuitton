using System;
using System.Collections.Generic;

#nullable disable

namespace NowSaiGon.Models
{
    public partial class TblOrder
    {
        public TblOrder()
        {
            TblOrderDetails = new HashSet<TblOrderDetail>();
        }

        public int OrderId { get; set; }
        public int? CusId { get; set; }
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public decimal? ToltalAmount { get; set; }
        public int? Quantity { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifierDate { get; set; }
        public string ModifierBy { get; set; }

        public virtual TblCustomer Cus { get; set; }
        public virtual ICollection<TblOrderDetail> TblOrderDetails { get; set; }
    }
}
