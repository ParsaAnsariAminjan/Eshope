using System.ComponentModel.DataAnnotations;

namespace EShope.ViewModels.Account
{
    public class RegisterViewModel
    {
       


        [Display(Name ="ایمیل")]
        [Required(ErrorMessage ="لطفا {0} را وارد نمایید")]
        [EmailAddress(ErrorMessage ="آدرس ایمیل وارد شده معتبر نمی باشد")]
        [MaxLength(150,ErrorMessage ="طول عبارت وارد شده نباید بیشتر از {1} کاراکتر باشد")]
        public string Email { get; set; }

        [Display(Name = "پسورد")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(20, ErrorMessage = "طول {0} وارد شده نباید بیشتر از {1} کاراکتر باشد")]
        public string Password { get; set; }

        [Display(Name = "پسورد")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(20, ErrorMessage = "طول تکرار {0} وارد شده نباید بیشتر از {1} کاراکتر باشد")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

    }
}
