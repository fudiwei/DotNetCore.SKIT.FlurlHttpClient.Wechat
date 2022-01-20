namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /merchant/group/getall 接口的响应。</para>
    /// </summary>
    public class MerchantGroupGetAllResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Group
            {
                /// <summary>
                /// 获取或设置分组 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("group_id")]
                [System.Text.Json.Serialization.JsonPropertyName("group_id")]
                public int GroupId { get; set; }

                /// <summary>
                /// 获取或设置分组名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("group_name")]
                [System.Text.Json.Serialization.JsonPropertyName("group_name")]
                public string Name { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置分组列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("groups_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("groups_detail")]
        public Types.Group[] GroupList { get; set; } = default!;
    }
}
