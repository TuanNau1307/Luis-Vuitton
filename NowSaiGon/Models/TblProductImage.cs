using System;
using System.Collections.Generic;

#nullable disable

namespace NowSaiGon.Models
{
    public partial class TblProductImage
    {
        public int ImgId { get; set; }
        public int? ProId { get; set; }
        public string Image { get; set; }
        public bool? Published { get; set; }
        public bool? IsNew { get; set; }
        public bool? IsHot { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifierDate { get; set; }
        public string ModifierBy { get; set; }

        public virtual TblProduct Pro { get; set; }
    }
}
