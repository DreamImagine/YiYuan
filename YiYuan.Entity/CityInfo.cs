using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YiYuan.Entity
{
    /// <summary>
    /// 城市信息
    /// </summary>
    [Table("CityInfo")]
    public class CityInfo : EntityBase<int>
    {
        /// <summary>
        /// 城市名称
        /// </summary>
        [Column(TypeName = "VARCHAR")]
        [Display(Name = "城市名称")]
        [StringLength(20)]
        [Required]
        public string CityName { get; set; }

    }
}