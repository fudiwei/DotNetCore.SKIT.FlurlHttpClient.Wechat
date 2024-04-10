namespace SKIT.FlurlHttpClient.Wechat.Work.ExtendedSDK.Finance.Models
{
    /// <summary>
    /// <para>表示会话内容存档之获取会话记录数据接口的请求。</para>
    /// </summary>
    public class GetChatRecordsRequest : WechatWorkFinanceRequest
    {
        /// <summary>
        /// 获取或设置起始序号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public ulong LastSequence { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：1000</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int Limit { get; set; } = 1000;
    }
}
