using System;
namespace YiYuan.Entity
{

    /// <summary>
    /// 用户操作记录_web
    /// </summary>
    public class UserOperateWebRecord : EntityBase<int>
    {
        public UserOperateWebRecord()
        {
            var nowTime = DateTime.Now;
            OperateTime = nowTime;
            BeginTime = nowTime;          
            Successd = true;
            ErrorMeg = "";
        }

        /// <summary>
        /// 请求头部
        /// </summary>
        public string Headers { get; set; }

        /// <summary>
        /// 来源地址
        /// </summary>		
        public string Referrer { get; set; }

        /// <summary>
        /// 请求方式
        /// </summary>
        public string Method { get; set; }

        /// <summary>
        /// IP地址
        /// </summary>		
        public string IPAddres { get; set; }

        /// <summary>
        /// 访问地址
        /// </summary>		
        public string Url { get; set; }

        /// <summary>
        /// 参数集合
        /// </summary>		
        public string ActionArguments { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>		
        public DateTime OperateTime { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime BeginTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 执行秒
        /// </summary>
        public double ExecTime { get; set; }

        /// <summary>
        /// 正常通过
        /// </summary>
        public bool Successd { get; set; }

        /// <summary>
        /// 不通过时，错误信息
        /// </summary>
        public string ErrorMeg { get; set; }
    }
}