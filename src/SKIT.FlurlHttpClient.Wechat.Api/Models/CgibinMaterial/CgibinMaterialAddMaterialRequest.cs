using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/material/add_material 接口的请求。</para>
    /// </summary>
    public class CgibinMaterialAddMaterialRequest : WechatApiRequest, IMapResponse<CgibinMaterialAddMaterialRequest, CgibinMaterialAddMaterialResponse>
    {
        /// <summary>
        /// 获取或设置媒体文件类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置文件字节数组。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] FileBytes { get; set; } = new byte[0];

        /// <summary>
        /// 获取或设置文件名。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? FileName { get; set; }

        /// <summary>
        /// 获取或设置文件 Conent-Type。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? FileContentType { get; set; }

        /// <summary>
        /// 获取或设置视频标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? VideoTitle { get; set; }

        /// <summary>
        /// 获取或设置视频描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("introduction")]
        [System.Text.Json.Serialization.JsonPropertyName("introduction")]
        public string? VideoDescription { get; set; }
    }
}
