namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxaapi/log/get_client_version 接口的响应。</para>
    /// </summary>
    public class WxaApiLogGetClientVersionResponse : WechatApiResponse
    {
        public static class Types
        {
            public class ClientVersionData
            {
                /// <summary>
                /// 获取或设置查询类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置客户端版本列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("client_version_list")]
                [System.Text.Json.Serialization.JsonPropertyName("client_version_list")]
                public string[] ClientVersionList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置客户端版本数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cvlist")]
        [System.Text.Json.Serialization.JsonPropertyName("cvlist")]
        public Types.ClientVersionData[] ClientVersionDataList { get; set; } = default!;
    }
}
