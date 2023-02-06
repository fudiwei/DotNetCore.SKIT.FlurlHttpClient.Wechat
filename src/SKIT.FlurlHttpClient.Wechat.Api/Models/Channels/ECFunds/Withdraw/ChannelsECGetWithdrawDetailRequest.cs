namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/funds/getwithdrawdetail 接口的请求。</para>
    /// </summary>
    public class ChannelsECGetWithdrawDetailRequest : WechatApiRequest, IInferable<ChannelsECGetWithdrawDetailRequest, ChannelsECGetWithdrawDetailResponse>
    {
        /// <summary>
        /// 获取或设置提现单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("withdraw_id")]
        [System.Text.Json.Serialization.JsonPropertyName("withdraw_id")]
        public string WithdrawId { get; set; } = string.Empty;
    }
}
