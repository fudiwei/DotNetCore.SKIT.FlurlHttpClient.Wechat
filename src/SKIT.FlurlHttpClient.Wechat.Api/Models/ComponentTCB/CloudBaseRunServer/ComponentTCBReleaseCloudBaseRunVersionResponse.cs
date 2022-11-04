namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/releasecloudbaserunversion 接口的响应。</para>
    /// </summary>
    public class ComponentTCBReleaseCloudBaseRunVersionResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置创建结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public string Result { get; set; } = default!;

        /// <summary>
        /// 获取或设置发布订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("release_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("release_order_id")]
        public long? ReleaseOrderId { get; set; }
    }
}
