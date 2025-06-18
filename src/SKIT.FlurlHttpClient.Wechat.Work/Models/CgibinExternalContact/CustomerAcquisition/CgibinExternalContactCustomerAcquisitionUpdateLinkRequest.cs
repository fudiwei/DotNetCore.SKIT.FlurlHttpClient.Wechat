using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/customer_acquisition/update_link 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactCustomerAcquisitionUpdateLinkRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Range : CgibinExternalContactCustomerAcquisitionCreateLinkRequest.Types.Range
            {
            }
        }

        /// <summary>
        /// 获取或设置获客链 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("link_id")]
        [System.Text.Json.Serialization.JsonPropertyName("link_id")]
        public string LinkId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置获客链接名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("link_name")]
        [System.Text.Json.Serialization.JsonPropertyName("link_name")]
        public string? LinkName { get; set; }

        /// <summary>
        /// 获取或设置使用范围信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("range")]
        [System.Text.Json.Serialization.JsonPropertyName("range")]
        public Types.Range? Range { get; set; }

        /// <summary>
        /// 获取或设置是否无需验证。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("skip_verify")]
        [System.Text.Json.Serialization.JsonPropertyName("skip_verify")]
        public bool? IsSkipVerify { get; set; }
    }
}
