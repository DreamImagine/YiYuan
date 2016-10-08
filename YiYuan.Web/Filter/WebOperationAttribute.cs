using System;
using System.Configuration;
using System.Web.Helpers;
using System.Web.Mvc;
using YiYuan.Business;
using YiYuan.Entity;

namespace YiYuan.Web.Filter
{

    /// <summary>
    /// web 自定义操作记录
    /// </summary>
    public class WebOperationAttribute : FilterAttribute, IActionFilter
    {
        UserOperateWebRecord userOperateWebRecord { get; set; }

        /// <summary>
        /// 在执行操作方法之前调用。
        /// </summary>
        /// <param name="filterContext">筛选器上下文。</param>
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {

            userOperateWebRecord = new UserOperateWebRecord();

            userOperateWebRecord.IPAddres = WebCommon.getIp();

            var currentRequest = filterContext.HttpContext.Request;

            var actionArguments = filterContext.ActionParameters;

            userOperateWebRecord.ActionArguments = Json.Encode(actionArguments);

            userOperateWebRecord.Method = currentRequest.HttpMethod;

            userOperateWebRecord.OperateTime = DateTime.Now;

            var currentReferrer = currentRequest.UrlReferrer;

            userOperateWebRecord.Headers = currentRequest.Headers.ToString();

            userOperateWebRecord.Referrer = currentReferrer == null ? "" : currentReferrer.ToString();

            if (currentRequest.Url != null)
            {
                userOperateWebRecord.Url = currentRequest.Url.ToString();
            }

        }


        /// <summary>
        /// 在执行操作方法后调用。
        /// </summary>
        /// <param name="filterContext">筛选器上下文。</param>
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {

            userOperateWebRecord.EndTime = DateTime.Now;

            userOperateWebRecord.ExecTime = (userOperateWebRecord.EndTime - userOperateWebRecord.BeginTime).TotalSeconds;

            if (filterContext.Exception != null)
            {
                userOperateWebRecord.Successd = false;
                userOperateWebRecord.ErrorMeg = filterContext.Exception.Message;
            }

            new UserOperateWebRecordBusiness().AddAsync(userOperateWebRecord);

        }

    }
}