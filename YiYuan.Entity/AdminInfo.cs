using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YiYuan.Entity
{
    /// <summary>
    /// 管理员信息
    /// </summary>
    public class AdminInfo : EntityBase<int>
    {        /// <summary>
             /// 用户名称
             /// </summary>
        [Column(TypeName = "VARCHAR")]
        [Display(Name = "用户名称")]
        [StringLength(100)]
        public string Username { get; set; }


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
    }
}
