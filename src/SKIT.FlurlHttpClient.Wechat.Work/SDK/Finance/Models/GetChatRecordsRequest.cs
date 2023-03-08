namespace SKIT.FlurlHttpClient.Wechat.Work.SDK.Finance.Models
{
    public class GetChatRecordsRequest : WechatWorkFinanceRequest
    {
        /// <summary>
        /// 获取或设置起始序号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long LastSequence { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：1000</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int Limit { get; set; } = 1000;
    }
}
