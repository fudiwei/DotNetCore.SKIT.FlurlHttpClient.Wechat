using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/business/printer/update 接口的请求。</para>
    /// </summary>
    public class CgibinExpressBusinessPrinterUpdateRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置执行操作。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_type")]
        [System.Text.Json.Serialization.JsonPropertyName("update_type")]
        public string Action { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置打印员用户 OpenId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string PrinterOpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置打印员面单打印权限列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tagid_list")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualStringListWithCommaSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("tagid_list")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualStringListWithCommaSplitConverter))]
        public IList<string>? TagIdList { get; set; }
    }
}
