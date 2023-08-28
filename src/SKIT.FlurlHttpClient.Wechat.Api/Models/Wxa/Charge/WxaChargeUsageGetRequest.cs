namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/charge/usage/get 接口的请求。</para>
    /// </summary>
    public class WxaChargeUsageGetRequest : WechatApiRequest, IInferable<WxaChargeUsageGetRequest, WxaChargeUsageGetResponse>
    {
        /// <summary>
        /// 获取或设置商品 SPU ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SPUId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：20</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int Limit { get; set; } = 20;
    }
}
