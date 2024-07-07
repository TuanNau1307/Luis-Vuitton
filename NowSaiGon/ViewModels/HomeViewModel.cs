using NowSaiGon.Models;
using System.Collections.Generic;

namespace NowSaiGon.ViewModels
{
    public class HomeViewModel
    {
        public List<TblCategory> Category { get; set; }
        public List<TblProduct> Products { get; set; }
    }
}
