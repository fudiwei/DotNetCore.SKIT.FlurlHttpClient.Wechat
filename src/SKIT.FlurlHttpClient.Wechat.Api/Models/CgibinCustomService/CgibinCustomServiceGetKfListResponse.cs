namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/customservice/getkflist 接口的响应。</para>
    /// </summary>
    public class CgibinCustomServiceGetKfListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Kf
            {
                /// <summary>
                /// 获取或设置客服 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("kf_id")]
                [System.Text.Json.Serialization.JsonPropertyName("kf_id")]
                public string KfId { get; set; } = default!;

                /// <summary>
                /// 获取或设置客服账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("kf_account")]
                [System.Text.Json.Serialization.JsonPropertyName("kf_account")]
                public string KfAccount { get; set; } = default!;

                /// <summary>
                /// 获取或设置客服昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("kf_nick")]
                [System.Text.Json.Serialization.JsonPropertyName("kf_nick")]
                public string Nickname { get; set; } = default!;

                /// <summary>
                /// 获取或设置客服头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("kf_headimgurl")]
                [System.Text.Json.Serialization.JsonPropertyName("kf_headimgurl")]
                public string HeadImageUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置客服微信号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("kf_wx")]
                [System.Text.Json.Serialization.JsonPropertyName("kf_wx")]
                public string? Wxname { get; set; }

                /// <summary>
                /// 获取或设置绑定邀请的微信号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("invite_wx")]
                [System.Text.Json.Serialization.JsonPropertyName("invite_wx")]
                public string? InviteWxname { get; set; }

                /// <summary>
                /// 获取或设置绑定邀请的过期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("invite_expire_time")]
                [System.Text.Json.Serialization.JsonPropertyName("invite_expire_time")]
                public long? InviteExpireTimestamp { get; set; }

                /// <summary>
                /// 获取或设置绑定邀请的状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("invite_status")]
                [System.Text.Json.Serialization.JsonPropertyName("invite_status")]
                public string? InviteStatus { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置客服列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kf_list")]
        [System.Text.Json.Serialization.JsonPropertyName("kf_list")]
        public Types.Kf[] KfList { get; set; } = default!;
    }
}
