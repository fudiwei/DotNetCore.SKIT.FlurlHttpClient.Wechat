namespace SKIT.FlurlHttpClient.Wechat.Work.SDK.Finance.Models
{
    public class GetChatDataRequest : WechatWorkFinanceRequest
    {
        /// <summary>
        /// 获取或设置分页游标。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long Cursor { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：1000</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int Limit { get; set; } = 1000;
    }
}
