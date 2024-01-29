using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/getmedialink 接口的请求。</para>
    /// </summary>
    public class WxaSecVodGetMediaLinkRequest : WechatApiRequest, IInferable<WxaSecVodGetMediaLinkRequest, WxaSecVodGetMediaLinkResponse>
    {
        /// <summary>
        /// 获取或设置媒资文件 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_id")]
        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
        public long MediaId { get; set; }

        /// <summary>
        /// 获取或设置过期时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("t")]
        [System.Text.Json.Serialization.JsonPropertyName("t")]
        public long ExpireTimestamp { get; set; }

        /// <summary>
        /// 获取或设置试看时长（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expr")]
        [System.Text.Json.Serialization.JsonPropertyName("expr")]
        public int? ExperienceTime { get; set; }

        /// <summary>
        /// 获取或设置最多允许多少个不同 IP 的终端播放。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rlimit")]
        [System.Text.Json.Serialization.JsonPropertyName("rlimit")]
        public int? IpLimit { get; set; }

        /// <summary>
        /// 获取或设置允许访问的域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("whref")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedStringListWithCommaSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("whref")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedStringListWithCommaSplitConverter))]
        public IList<string>? DomainWhiteList { get; set; }

        /// <summary>
        /// 获取或设置禁止访问的域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bkref")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedStringListWithCommaSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("bkref")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedStringListWithCommaSplitConverter))]
        public IList<string>? DomainBlackList { get; set; }
    }
}
