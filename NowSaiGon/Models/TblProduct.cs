using System;
using System.Collections.Generic;

#nullable disable

namespace NowSaiGon.Models
{
    public partial class TblProduct
    {
        public TblProduct()
        {
            TblOrderDetails = new HashSet<TblOrderDetail>();
            TblProductDetails = new HashSet<TblProductDetail>();
            TblProductImages = new HashSet<TblProductImage>();
        }

        public int ProId { get; set; }
        public string ProName { get; set; }
        public int? Id { get; set; }
        public string Decription { get; set; }
        public string Detail { get; set; }
        public string Avatar { get; set; }
        public decimal? Price { get; set; }
        public decimal? PriceSale { get; set; }
        public bool? Published { get; set; }
        public bool? IsNew { get; set; }
        public bool? IsHot { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifierDate { get; set; }
        public string ModifierBy { get; set; }

        public virtual TblCategory IdNavigation { get; set; }
        public virtual ICollection<TblOrderDetail> TblOrderDetails { get; set; }
        public virtual ICollection<TblProductDetail> TblProductDetails { get; set; }
        public virtual ICollection<TblProductImage> TblProductImages { get; set; }
    }
}
