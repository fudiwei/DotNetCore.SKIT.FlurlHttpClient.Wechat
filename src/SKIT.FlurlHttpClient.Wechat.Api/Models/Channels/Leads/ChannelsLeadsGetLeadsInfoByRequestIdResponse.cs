namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/leads/get_leads_info_by_request_id 接口的响应。</para>
    /// </summary>
    public class ChannelsLeadsGetLeadsInfoByRequestIdResponse : WechatApiResponse
    {
        public static class Types
        {
            public class UserData : ChannelsLeadsGetLeadsInfoByComponentIdResponse.Types.UserData
            {
            }
        }

        /// <summary>
        /// 获取或设置用户留资信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_data")]
        [System.Text.Json.Serialization.JsonPropertyName("user_data")]
        public Types.UserData[] UserDataList { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否还有更多。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("continue_flag")]
        [System.Text.Json.Serialization.JsonPropertyName("continue_flag")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("last_buffer")]
        [System.Text.Json.Serialization.JsonPropertyName("last_buffer")]
        public string? NextCursor { get; set; }
    }
}
