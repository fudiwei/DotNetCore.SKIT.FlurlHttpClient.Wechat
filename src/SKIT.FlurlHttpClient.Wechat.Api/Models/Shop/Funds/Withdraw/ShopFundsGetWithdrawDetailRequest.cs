namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/funds/getwithdrawdetail 接口的请求。</para>
    /// </summary>
    public class ShopFundsGetWithdrawDetailRequest : WechatApiRequest, IInferable<ShopFundsGetWithdrawDetailRequest, ShopFundsGetWithdrawDetailResponse>
    {
        /// <summary>
        /// 获取或设置提现单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string OutRequestNumber { get; set; } = string.Empty;
    }
}
