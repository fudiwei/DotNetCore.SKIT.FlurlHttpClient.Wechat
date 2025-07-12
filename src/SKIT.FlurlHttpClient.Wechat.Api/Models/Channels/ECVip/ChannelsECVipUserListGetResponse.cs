namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/vip/user/list/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECVipUserListGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class UserInfo
            {
                /// <summary>
                /// 获取或设置小程序用户的 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wxa_openid")]
                [System.Text.Json.Serialization.JsonPropertyName("wxa_openid")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户会员身份。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("identity")]
                [System.Text.Json.Serialization.JsonPropertyName("identity")]
                public string Identity { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户会员 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("outer_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("outer_userid")]
                public string? OutUserId { get; set; }

                /// <summary>
                /// 获取或设置已关联的小店 AppId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("related_shop_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("related_shop_appid")]
                public string[] RelatedShopAppIdList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置小程序用户列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.UserInfo[] UserList { get; set; } = default!;
    }
}
