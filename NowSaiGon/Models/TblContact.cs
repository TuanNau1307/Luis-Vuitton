using System;
using System.Collections.Generic;

#nullable disable

namespace NowSaiGon.Models
{
    public partial class TblContact
    {
        public int ConId { get; set; }
        public string Name { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public bool? IsRead { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifierDate { get; set; }
        public string ModifierBy { get; set; }
    }
}
