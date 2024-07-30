using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/vip/user/score/get 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-07-22 下线。")]
    public class ChannelsECVipUserScoreGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class UserInfo
            {
                /// <summary>
                /// 获取或设置用户积分。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("score")]
                [System.Text.Json.Serialization.JsonPropertyName("score")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int Score { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置用户信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info")]
        [System.Text.Json.Serialization.JsonPropertyName("info")]
        public Types.UserInfo UserInfo { get; set; } = default!;
    }
}
