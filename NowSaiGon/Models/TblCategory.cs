using System;
using System.Collections.Generic;

#nullable disable

namespace NowSaiGon.Models
{
    public partial class TblCategory
    {
        public TblCategory()
        {
            TblProducts = new HashSet<TblProduct>();
        }

        public int Id { get; set; }
        public string CatName { get; set; }
        public string Description { get; set; }
        public int? Position { get; set; }
        public int? Levels { get; set; }
        public int? Parent { get; set; }
        public string Image { get; set; }
        public bool? Published { get; set; }
        public bool? IsNew { get; set; }
        public bool? IsHot { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifierDate { get; set; }
        public string ModifierBy { get; set; }

        public virtual ICollection<TblProduct> TblProducts { get; set; }
    }
}
