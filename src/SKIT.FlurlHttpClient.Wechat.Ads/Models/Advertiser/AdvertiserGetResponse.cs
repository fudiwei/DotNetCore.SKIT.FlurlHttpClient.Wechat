namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [GET] /advertiser/get 接口的响应。</para>
    /// </summary>
    public class AdvertiserGetResponse : WechatAdsResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置公众号名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wechat_account_name")]
                [System.Text.Json.Serialization.JsonPropertyName("wechat_account_name")]
                public string WechatAccountNickname { get; set; } = default!;

                /// <summary>
                /// 获取或设置系统状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("system_status")]
                [System.Text.Json.Serialization.JsonPropertyName("system_status")]
                public string SystemStatus { get; set; } = default!;

                /// <summary>
                /// 获取或设置行业 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("industry_id")]
                [System.Text.Json.Serialization.JsonPropertyName("industry_id")]
                public int IndustryId { get; set; }

                /// <summary>
                /// 获取或设置联系人姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_person")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_person")]
                public string ContactPerson { get; set; } = default!;

                /// <summary>
                /// 获取或设置联系人电话号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_person_telephone")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_person_telephone")]
                public string ContactTeleNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置经营性质类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("business_type")]
                [System.Text.Json.Serialization.JsonPropertyName("business_type")]
                public string? BusinessType { get; set; }

                /// <summary>
                /// 获取或设置经营内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("business_content")]
                [System.Text.Json.Serialization.JsonPropertyName("business_content")]
                public string? BusinessContent { get; set; }
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
