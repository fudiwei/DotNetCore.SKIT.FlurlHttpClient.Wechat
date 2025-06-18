namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/operationams?action=agency_get_black_list 接口的响应。</para>
    /// </summary>
    public class WxaOperationAMSAgencyGetBlackListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Advertiser
            {
                /// <summary>
                /// 获取或设置广告主 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public string Id { get; set; } = default!;

                /// <summary>
                /// 获取或设置广告主名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置广告主头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("icon")]
                [System.Text.Json.Serialization.JsonPropertyName("icon")]
                public string IconUrl { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ret")]
        [System.Text.Json.Serialization.JsonPropertyName("ret")]
        public int ReturnCode { get; set; }

        /// <summary>
        /// 获取或设置返回错误信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
        public string? ReturnMessage { get; set; }

        /// <summary>
        /// 获取或设置屏蔽的广告主列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("blacklist_biz")]
        [System.Text.Json.Serialization.JsonPropertyName("blacklist_biz")]
        public Types.Advertiser[] BlackList { get; set; } = default!;

        /// <summary>
        /// 获取或设置屏蔽的小程序广告主列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("blacklist_weapp")]
        [System.Text.Json.Serialization.JsonPropertyName("blacklist_weapp")]
        public Types.Advertiser[]? WeappBlackList { get; set; }

        /// <summary>
        /// 获取或设置屏蔽的 iOS 广告主列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("blacklist_ios")]
        [System.Text.Json.Serialization.JsonPropertyName("blacklist_ios")]
        public Types.Advertiser[]? IOSBlackList { get; set; }

        /// <summary>
        /// 获取或设置屏蔽的 Android 广告主列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("blacklist_android")]
        [System.Text.Json.Serialization.JsonPropertyName("blacklist_android")]
        public Types.Advertiser[]? AndroidBlackList { get; set; }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && ReturnCode == 0;
        }
    }
}
