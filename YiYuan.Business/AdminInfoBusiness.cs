using YiYuan.Entity;
using YiYuan.ViewModel;

namespace YiYuan.Business
{
    /// <summary>
    /// 
    /// </summary>
    public class AdminInfoBusiness : BaseBusiness<AdminInfo>
    {
        public dynamic Login(AdminInfoLoginViewModel login)
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
    }
}
