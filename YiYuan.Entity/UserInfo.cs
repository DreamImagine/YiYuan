using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YiYuan.Entity
{
    /// <summary>
    /// 用户信息
    /// </summary>
    [Table("UserInfo")]
    public class UserInfo : EntityBase<int>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserInfo"/> class.
        /// </summary>
        public UserInfo()
        {
            DataState = DataState.Normal;
        }

        /// <summary>
        /// 用户名称
        /// </summary>
        [Column(TypeName = "VARCHAR")]
        [Display(Name = "用户名称")]
        [StringLength(100)]
        public string Username { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [Column(TypeName = "NVARCHAR")]
        [Display(Name = "用户昵称")]
        [StringLength(100)]
        public string NickName { get; set; }

        /// <summary>
        /// 幸运号码
        /// <para>用户自己设计的幸运号码</para>
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// 密码(MD5)
        /// </summary>
        [Column(TypeName = "CHAR")]
        [Display(Name = "密码(MD5)")]
        [StringLength(32)]
        [Required]
        public string Password { get; set; }

        /// <summary>
        /// 密码盐(MD5)
        /// <para>用户混淆密码</para>
        /// </summary>
        [Column(TypeName = "CHAR")]
        [StringLength(32)]
        [Required]
        public string Salt { get; set; }

        /// <summary>
        /// 真实姓名
        /// </summary>       
        [Display(Name = "真实姓名")]
        [StringLength(10)]
        public string RealName { get; set; }

        /// <summary>
        /// 移动电话
        /// </summary>
        [Column(TypeName = "CHAR")]
        [Display(Name = "移动电话")]
        [StringLength(11)]
        public string Mobile { get; set; }

        /// <summary>
        /// 用户头像
        /// </summary>
        [Column(TypeName = "VARCHAR")]
        [Display(Name = "用户头像")]
        [StringLength(128)]
        public string Avatar { get; set; }

        /// <summary>
        /// 令牌
        /// </summary>
        [Column(TypeName = "CHAR")]
        [StringLength(32)]
        public string Token { get; set; }

        /// <summary>
        /// 已充值金额
        /// </summary>
        [Display(Name = "用户余额")]
        public decimal RechargePrice { get; set; }


        /// <summary>
        /// 城市编码
        /// </summary>
        [Display(Name = "城市编码")]
        public string CityCode { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [Display(Name = "状态")]
        public DataState DataState { get; set; }

        /// <summary>
        /// 注册提交来源
        /// <para>web, 安卓</para>
        /// </summary>
        [Display(Name = "注册提交来源")]
        public SubmitSource SubmitSource { get; set; }
    }
}