namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/getwxagameidentityinfo 接口的响应。</para>
    /// </summary>
    public class WxaGetWxaGameIdentityInfoResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Identity
                    {
                        /// <summary>
                        /// 获取或设置玩家在房间里的唯一标识。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("client_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("client_id")]
                        public int ClientId { get; set; }

                        /// <summary>
                        /// 获取或设置玩家 OpenId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("open_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
                        public string FrameId { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置玩家位次列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("info_list")]
                [System.Text.Json.Serialization.JsonPropertyName("info_list")]
                public Types.Identity[] IdentityList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置对局玩家位次数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
