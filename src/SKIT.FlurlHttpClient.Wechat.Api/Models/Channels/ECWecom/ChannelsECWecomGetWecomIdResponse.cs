namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/wecom/get_wecom_id 接口的响应。</para>
    /// </summary>
    public class ChannelsECWecomGetWecomIdResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置企业微信 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wecom_corp_id")]
                [System.Text.Json.Serialization.JsonPropertyName("wecom_corp_id")]
                public string WecomAppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置企业微信账号 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wecom_user_id")]
                [System.Text.Json.Serialization.JsonPropertyName("wecom_user_id")]
                public string WecomUserId { get; set; } = default!;
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
