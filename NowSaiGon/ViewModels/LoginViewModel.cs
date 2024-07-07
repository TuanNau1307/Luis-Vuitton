using System.ComponentModel.DataAnnotations;

namespace NowSaiGon.ViewModels
{
    public class LoginViewModel
    {
        [Key]
        [MaxLength(100)]
        [Required(ErrorMessage ="Vui lòng  nhập email")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [Display(Name ="Email")]
        public string Username { get; set; }
        [Display(Name = "Mật khẩu")]
        [Required(ErrorMessage = "Vui lòng  nhập mật khẩu")]
        [MinLength(6,ErrorMessage ="Tối thiểu 6 kí tự")]
        public string Password { get; set; }
    }
}
