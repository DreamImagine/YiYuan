using System;
using YiYuan.Entity;
using YiYuan.ViewModel;
namespace YiYuan.Business
{
    public class UserInfoBusiness : BaseBusiness<UserInfo>
    {

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public dynamic Login(UserLoginViewModel login)
        {
            var singleUser = GetSingleByWhere<dynamic>(t => t.Username == login.Username, t => new { t.Id, t.Password, t.Salt }).Data;

            if (singleUser == null)
            {
                return new BusinessResponse(false, "该账号还未注册", "该账号还未注册");
            }

            var inputPassword = ExtendHelper.MD5(login.Password + singleUser.Salt);

            if (inputPassword != singleUser.Password)
            {
                return new BusinessResponse(false, "密码不正确", "密码不正确");
            }

            return new BusinessResponse<dynamic>(new { singleUser.Id });
        }

        /// <summary>
        /// 注册
        /// </summary>
        /// <returns></returns>
        public dynamic Register(UserLoginViewModel register)
        {
            if (AnyByWhere(t => t.Username == register.Username).Data)
            {
                return new BusinessResponse(false, "该账号已注册", "该账号已注册");
            }

            var userInfo = new UserInfo()
            {
                Username = register.Username,
                Mobile = register.Username
            };

            userInfo.Salt = ExtendHelper.MD5(Guid.NewGuid().ToString("N").Substring(1, 5));
            userInfo.Password = ExtendHelper.MD5(register.Password + userInfo.Salt);

            context.UserInfo.Add(userInfo);

            context.SaveChangesAsync();

            return new BusinessResponse();
        }


    }


}
