using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http.Results;

namespace YiYuan.Web
{

    /// <summary>
    /// 
    /// </summary>
    public static class WebCommon
    {
        /// <summary>
        /// 获得当前IP
        /// </summary>
        /// <returns></returns>

        public static string getIp()
        {

            var realRemoteIP = "";

            if (HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != null)
            {

                realRemoteIP = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].Split(',')[0];

            }

            if (string.IsNullOrEmpty(realRemoteIP))
            {

                realRemoteIP = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];

            }

            if (string.IsNullOrEmpty(realRemoteIP))
            {

                realRemoteIP = HttpContext.Current.Request.UserHostAddress;

            }

            return realRemoteIP;
        }

        /// <summary>
        /// 获得错误信息
        /// </summary>
        /// <param name="validResult"></param>
        /// <returns></returns>
        public static string GetMsg(InvalidModelStateResult validResult)
        {

            var msg = "";

            var firstOrDefault = validResult.ModelState.Values.FirstOrDefault();

            if (firstOrDefault == null)
            {
                return msg;
            }
            var modelError = firstOrDefault.Errors.FirstOrDefault();

            if (modelError != null)
            {
                msg = modelError.ErrorMessage;
            }

            return msg;
        }

        /// <summary>
        /// 向服务器提交数据，并获取服务器响应的数据
        /// </summary>
        /// <param name="url">服务器地址</param>
        /// <param name="responseData">返回响应数据</param>
        /// /// <param name="httpMethod">http方法</param>
        /// <param name="data">数据</param>
        /// <returns>返回是否提交成功</returns>
        public static bool Request(string url, out byte[] responseData,
            string httpMethod = WebRequestMethods.Http.Get, byte[] data = null)
        {
            bool success = false;
            responseData = null;
            Stream requestStream = null;
            HttpWebResponse response = null;
            Stream responseStream = null;
            MemoryStream ms = null;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = httpMethod;
                if (data != null && data.Length > 0)
                {
                    request.ContentLength = data.Length;
                    requestStream = request.GetRequestStream();
                    requestStream.Write(data, 0, data.Length);
                }
                response = (HttpWebResponse)request.GetResponse();
                //由于服务器的响应有时没有正确设置ContentLength，这里不检查ContentLength
                //if (response.ContentLength > 0)
                {
                    ms = new MemoryStream();
                    responseStream = response.GetResponseStream();
                    int bufferLength = 2048;
                    byte[] buffer = new byte[bufferLength];
                    int size = responseStream.Read(buffer, 0, bufferLength);
                    while (size > 0)
                    {
                        ms.Write(buffer, 0, size);
                        size = responseStream.Read(buffer, 0, bufferLength);
                    }
                    responseData = ms.ToArray();
                }
                success = true;
            }
            finally
            {
                if (requestStream != null)
                    requestStream.Close();
                if (responseStream != null)
                    responseStream.Close();
                if (ms != null)
                    ms.Close();
                if (response != null)
                    response.Close();
            }
            return success;
        }
    }
}