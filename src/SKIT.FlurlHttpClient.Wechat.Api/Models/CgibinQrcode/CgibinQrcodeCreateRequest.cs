namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/qrcode/create 接口的请求。</para>
    /// </summary>
    public class CgibinQrcodeCreateRequest : WechatApiRequest, IInferable<CgibinQrcodeCreateRequest, CgibinQrcodeCreateResponse>
    {
        public static class Types
        {
            public class Action
            {
                public static class Types
                {
                    public class Scene
                    {
                        /// <summary>
                        /// 获取或设置场景值 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("scene_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("scene_id")]
                        public long? SceneId { get; set; }

                        /// <summary>
                        /// 获取或设置场景描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("scene_str")]
                        [System.Text.Json.Serialization.JsonPropertyName("scene_str")]
                        public string? SceneString { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置场景信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("scene")]
                [System.Text.Json.Serialization.JsonPropertyName("scene")]
                public Types.Scene Scene { get; set; } = new Types.Scene();
            }
        }

        /// <summary>
        /// 获取或设置二维码有效期（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expire_seconds")]
        [System.Text.Json.Serialization.JsonPropertyName("expire_seconds")]
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// 获取或设置二维码类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action_name")]
        [System.Text.Json.Serialization.JsonPropertyName("action_name")]
        public string ActionType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置二维码详细信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action_info")]
        [System.Text.Json.Serialization.JsonPropertyName("action_info")]
        public Types.Action Action { get; set; } = new Types.Action();
    }
}
