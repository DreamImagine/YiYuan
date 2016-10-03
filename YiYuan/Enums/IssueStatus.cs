namespace YiYuan.Enums
{
    /// <summary>
    /// 期号状态
    /// </summary>
    public enum IssueStatus : byte
    {
        //1.为开始 
        //2.进行中 
        //3.待开奖，表示所有都买完，这个状态时继续生成下一期  3.已开奖  4.已发货 5.客户已收到
    }
}
