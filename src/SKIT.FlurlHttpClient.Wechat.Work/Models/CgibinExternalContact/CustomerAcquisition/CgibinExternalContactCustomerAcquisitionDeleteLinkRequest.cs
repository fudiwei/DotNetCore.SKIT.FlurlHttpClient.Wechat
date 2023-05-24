namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/customer_acquisition/delete_link 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactCustomerAcquisitionDeleteLinkRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置获客链接 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("link_id")]
        [System.Text.Json.Serialization.JsonPropertyName("link_id")]
        public string LinkId { get; set; } = string.Empty;
    }
}
