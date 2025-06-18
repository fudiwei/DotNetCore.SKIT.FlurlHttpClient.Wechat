namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [DELETE] /marketing/membercard-open/cards/{card_id} 接口的请求。</para>
    /// </summary>
    public class DeleteMarketingMemberCardOpenCardRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置会员卡 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string CardId { get; set; } = string.Empty;
    }
}
