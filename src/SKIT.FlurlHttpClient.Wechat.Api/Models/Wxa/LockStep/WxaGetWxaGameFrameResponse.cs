namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/getwxagameframe 接口的响应。</para>
    /// </summary>
    public class WxaGetWxaGameFrameResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Frame
                    {
                        public static class Types
                        {
                            public class Package
                            {
                                /// <summary>
                                /// 获取或设置该包发送者的 OpenId。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("open_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("open_id")]
                                public string FrameId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置第三方自定义游戏指令数组。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("action_list")]
                                [System.Text.Json.Serialization.JsonPropertyName("action_list")]
                                public string[]? ActionList { get; set; }

                                /// <summary>
                                /// 获取或设置是否是空帧。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("b")]
                                [System.Text.Json.Serialization.JsonPropertyName("b")]
                                public bool IsBlank { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置帧编号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("frame_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("frame_id")]
                        public int FrameId { get; set; }

                        /// <summary>
                        /// 获取或设置指令包列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pkg_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("pkg_list")]
                        public Types.Package[] PackageList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置是否还有更多帧可以获取。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("has_more")]
                [System.Text.Json.Serialization.JsonPropertyName("has_more")]
                public bool HasMore { get; set; }

                /// <summary>
                /// 获取或设置游戏帧数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("frame_list")]
                [System.Text.Json.Serialization.JsonPropertyName("frame_list")]
                public Types.Frame[] FrameList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置对局游戏帧数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
