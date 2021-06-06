using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/contact/id_translate 接口的请求。</para>
    /// </summary>
    public class CgibinServiceContactIdTranslateRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置授权方 CorpId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_corpid")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_corpid")]
        public string AuthorizerCorpId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置需要转译的文件 MediaId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("media_id_list")]
        public IList<string> MediaIdList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置转译后打包的文件名（不带后缀名）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("output_file_name")]
        [System.Text.Json.Serialization.JsonPropertyName("output_file_name")]
        public string? OutputFileName { get; set; }

        /// <summary>
        /// 获取或设置转译后打包的文件格式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("output_file_format")]
        [System.Text.Json.Serialization.JsonPropertyName("output_file_format")]
        public string? OutputFileFormat { get; set; }
    }
}
