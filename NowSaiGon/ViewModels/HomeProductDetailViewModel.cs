using NowSaiGon.Models;
using System.Collections.Generic;

namespace NowSaiGon.ViewModels
{
    public class HomeProductDetailViewModel
    {
        public TblProduct product { get; set; }
        public List<TblProductImage> proImg { get; set; }
        public List<TblProductDetail> productDetails { get; set; }
        public List<TblProduct> relatedProduct { get; set; }
    }
}
