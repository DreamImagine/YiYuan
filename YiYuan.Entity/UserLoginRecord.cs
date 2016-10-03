using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YiYuan.Entity
{
    /// <summary>
    /// 用户登录记录
    /// </summary>
    [Table("UserLoginRecord")]
    public class UserLoginRecord : EntityBase<int>
    {
        /// <summary>
        /// 账号
        /// </summary>
        [Required]
        [StringLength(50, ErrorMessage = "账号只能为50个字符")]
        public string Account { get; set; }

        /// <summary>
        /// 登陆成功
        /// </summary>
        public bool Successed { get; set; }

        /// <summary>
        /// IP地址
        /// </summary>
        [Column(TypeName = "VARCHAR")]
        [StringLength(15)]
        [Required]
        public string LoginIp { get; set; }

        /// <summary>
        /// 提交来源
        /// </summary>
        public SubmitSource SubmitSource { get; set; }

        /// <summary>
        /// 登陆信息
        /// </summary>
        [StringLength(50)]
        [Required]
        public string LoginMessage { get; set; }
    }
}