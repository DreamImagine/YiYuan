using System.ComponentModel.DataAnnotations;

namespace YiYuan.ViewModel
{
    public class UserLoginViewModel
    {

        /// <summary>
        /// 用户名称
        /// </summary>

        [Display(Name = "用户名称")]
        [StringLength(100)]
        [Required]
        public string Username { get; set; }

        /// <summary>
        /// 密码(MD5)
        /// </summary>
        [Display(Name = "密码(MD5)")]
        [StringLength(32)]
        [Required]
        public string Password { get; set; }
    }
}
