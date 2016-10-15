using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YiYuan.Entity
{
    /// <summary>
    /// 所有实体的基类
    /// </summary>
    /// <typeparam name="T">主键类型</typeparam>
    public class EntityBase<T>
    {

        public EntityBase()
        {
            CreateTime = DateTime.Now;
        }

        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        public T Id { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Column(TypeName = "DateTime")]
        [Display(Name = "创建时间")]
        public DateTime CreateTime { get; set; }

    }
}