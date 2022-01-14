namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/material/get_material 接口的响应。</para>
    /// </summary>
    public class CgibinMaterialGetMaterialAsVideoResponse : CgibinMaterialGetMaterialResponse
    {
        /// <summary>
        /// 获取或设置视频标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 获取或设置视频描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 获取或设置视频下载 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("down_url")]
        [System.Text.Json.Serialization.JsonPropertyName("down_url")]
        public string DownloadUrl { get; set; } = default!;
    }
}
