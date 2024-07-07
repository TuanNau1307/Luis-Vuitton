using System;
using System.Collections.Generic;

#nullable disable

namespace NowSaiGon.Models
{
    public partial class TblCustomer
    {
        public TblCustomer()
        {
            TblOrders = new HashSet<TblOrder>();
        }

        public int CusId { get; set; }
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }

        public virtual ICollection<TblOrder> TblOrders { get; set; }
    }
}
