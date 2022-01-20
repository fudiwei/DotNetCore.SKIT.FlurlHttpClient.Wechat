using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wxopen/qrcodejumpget 接口的请求。</para>
    /// </summary>
    public class CgibinWxopenQrcodeJumpGetRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? MiniProgramAppId { get; set; }

        /// <summary>
        /// 获取或设置查询方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("get_type")]
        [System.Text.Json.Serialization.JsonPropertyName("get_type")]
        public int? Type { get; set; }

        /// <summary>
        /// 获取或设置匹配前缀列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prefix_list")]
        [System.Text.Json.Serialization.JsonPropertyName("prefix_list")]
        public IList<string>? PrefixList { get; set; }

        /// <summary>
        /// 获取或设置分页页数（从 1 开始）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_num")]
        [System.Text.Json.Serialization.JsonPropertyName("page_num")]
        public int? Page { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int? Limit { get; set; }
    }
}
