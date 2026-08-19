namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/basics/video/uploadpart 接口的响应。</para>
    /// </summary>
    public class ChannelsECBasicsVideoUploadPartResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置分片 SHA-1 值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("part_sha")]
                [System.Text.Json.Serialization.JsonPropertyName("part_sha")]
                public string PartSha { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
