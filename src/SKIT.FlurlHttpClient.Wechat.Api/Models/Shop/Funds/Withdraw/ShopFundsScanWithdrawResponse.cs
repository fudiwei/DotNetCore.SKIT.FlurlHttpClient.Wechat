namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/funds/scanwithdraw 接口的响应。</para>
    /// </summary>
    public class ShopFundsScanWithdrawResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置提现单号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_nos")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_nos")]
        public string[] OutRequestNumberList { get; set; } = default!;

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int TotalCount { get; set; }
    }
}
