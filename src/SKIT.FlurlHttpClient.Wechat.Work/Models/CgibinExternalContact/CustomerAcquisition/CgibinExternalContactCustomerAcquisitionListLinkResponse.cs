namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/customer_acquisition/list_link 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactCustomerAcquisitionListLinkResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置获客链接 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("link_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("link_id_list")]
        public string[] LinkIdList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
