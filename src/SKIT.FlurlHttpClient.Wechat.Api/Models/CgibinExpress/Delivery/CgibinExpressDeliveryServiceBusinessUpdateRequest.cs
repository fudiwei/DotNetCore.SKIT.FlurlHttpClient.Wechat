namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/delivery/service/business/update 接口的请求。</para>
    /// </summary>
    public class CgibinExpressDeliveryServiceBusinessUpdateRequest : WechatApiRequest, IInferable<CgibinExpressDeliveryServiceBusinessUpdateRequest, CgibinExpressDeliveryServiceBusinessUpdateResponse>
    {
        /// <summary>
        /// 获取或设置商户的小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_app_id")]
        public string ShopAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置快递公司客户编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_id")]
        [System.Text.Json.Serialization.JsonPropertyName("biz_id")]
        public string BusinessId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置审核结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result_code")]
        [System.Text.Json.Serialization.JsonPropertyName("result_code")]
        public int ResultCode { get; set; }

        /// <summary>
        /// 获取或设置审核错误原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("result_msg")]
        public string? ResultMessage { get; set; }
    }
}
