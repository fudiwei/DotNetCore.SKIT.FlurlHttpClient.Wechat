namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/customer_acquisition/customer 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactCustomerAcquisitionCustomerRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置获客链接 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("link_id")]
        [System.Text.Json.Serialization.JsonPropertyName("link_id")]
        public string LinkId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }
    }
}
