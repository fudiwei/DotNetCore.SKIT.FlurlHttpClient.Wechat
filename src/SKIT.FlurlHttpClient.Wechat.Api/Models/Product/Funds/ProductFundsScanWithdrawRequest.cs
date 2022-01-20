namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/funds/scanwithdraw 接口的请求。</para>
    /// </summary>
    public class ProductFundsScanWithdrawRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置分页页数（从 1 开始）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_num")]
        [System.Text.Json.Serialization.JsonPropertyName("page_num")]
        public int Page { get; set; } = 1;

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int Limit { get; set; } = 10;
    }
}
