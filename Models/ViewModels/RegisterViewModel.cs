using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieProjectV2.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Hãy nhập tên của bạn")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập địa chỉ Email của bạn")]
        [EmailAddress(ErrorMessage = "Địa chỉ Email không hợp lệ")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập mật khẩu")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [StringLength(100, ErrorMessage ="Mật khẩu phải nhiều hơn 6 ký tự.", MinimumLength = 6)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage ="Mật khẩu và mật khẩu xác thực không giống")]
        public string ConfirmPassword { get; set; }

    }
}
