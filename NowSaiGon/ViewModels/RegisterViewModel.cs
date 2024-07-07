using System.ComponentModel.DataAnnotations;

namespace NowSaiGon.ViewModels
{
    public class RegisterViewModel
    {
        [Key]
        public int CusId { get;set; }
        public string CustomerName { get;set; }
        public string Email { get;set; }
        public string Phone { get;set; }
        public string Andress { get;set; }
        public string Pass { get;set; }
    }
}
