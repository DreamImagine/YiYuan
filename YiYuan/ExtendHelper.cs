using System.Security.Cryptography;
using System.Text;

namespace YiYuan
{
    /// <summary>
    /// 扩展帮助(助手)类
    /// </summary>
    public static class ExtendHelper
    {
        /// <summary>
        /// MD5 加密
        /// </summary>
        /// <param name="inputStr"></param>
        /// <returns></returns>
        public static string MD5(string inputStr)
        {
            MD5 mD5CryptoServiceProvider = System.Security.Cryptography.MD5.Create();
            byte[] numArray = mD5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(inputStr));
            StringBuilder stringBuilder = new StringBuilder();
            byte[] numArray1 = numArray;
            for (int i = 0; i < (int)numArray1.Length; i++)
            {
                byte num = numArray1[i];
                stringBuilder.Append(num.ToString("x").PadLeft(2, '0'));
            }
            return stringBuilder.ToString();
        }
    }
}
