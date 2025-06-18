namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/chatdata/get_hide_sensitiveinfo_config 接口的响应。</para>
    /// </summary>
    public class CgibinChatDataGetHideSensitiveInfoConfigResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Config
            {
                /// <summary>
                /// 获取或设置是否隐藏手机号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("hide_mobile")]
                [System.Text.Json.Serialization.JsonPropertyName("hide_mobile")]
                public bool IsHideMobileNumber { get; set; }

                /// <summary>
                /// 获取或设置是否隐藏身份证号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("hide_idcard")]
                [System.Text.Json.Serialization.JsonPropertyName("hide_idcard")]
                public bool IsHideIdCardNumber { get; set; }

                /// <summary>
                /// 获取或设置是否隐藏银行卡号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("hide_bankno")]
                [System.Text.Json.Serialization.JsonPropertyName("hide_bankno")]
                public bool IsHideBankCardNumber { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置配置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("config")]
        [System.Text.Json.Serialization.JsonPropertyName("config")]
        public Types.Config Config { get; set; } = default!;
    }
}
