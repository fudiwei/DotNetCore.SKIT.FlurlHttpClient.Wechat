namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/exmail/useroption/get 接口的响应。</para>
    /// </summary>
    public class CgibinExmailUserOptionGetResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class UserOptionList
            {
                /// <summary>
                /// 获取或设置功能设置列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public UserOptionItem[] Items { get; set; } = default!;
            }

            public class UserOptionItem
            {
                /// <summary>
                /// 获取或设置功能设置属性类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置功能设置属性值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("value")]
                [System.Text.Json.Serialization.JsonPropertyName("value")]
                public string Value { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置功能设置列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("option")]
        [System.Text.Json.Serialization.JsonPropertyName("option")]
        public Types.UserOptionList UserOptionList { get; set; } = default!;
    }
}
