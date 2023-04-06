namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/partnerships/terminate 接口的请求。</para>
    /// </summary>
    public class TerminateMarketingPartnershipRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Partner : BuildMarketingPartnershipRequest.Types.Partner
            {
            }

            public class AuthorizedData : BuildMarketingPartnershipRequest.Types.AuthorizedData
            {
            }
        }

        /// <summary>
        /// 获取或设置业务请求幂等值。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string IdempotencyKey { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置合作方信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("partner")]
        [System.Text.Json.Serialization.JsonPropertyName("partner")]
        public Types.Partner Partner { get; set; } = new Types.Partner();

        /// <summary>
        /// 获取或设置被授权数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorized_data")]
        [System.Text.Json.Serialization.JsonPropertyName("authorized_data")]
        public Types.AuthorizedData AuthorizedData { get; set; } = new Types.AuthorizedData();
    }
}
