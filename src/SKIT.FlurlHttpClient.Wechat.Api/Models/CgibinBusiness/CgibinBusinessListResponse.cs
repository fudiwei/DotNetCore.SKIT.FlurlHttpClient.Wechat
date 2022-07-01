namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/business/list 接口的响应。</para>
    /// </summary>
    public class CgibinBusinessListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class BusinessInfo : CgibinBusinessGetResponse.Types.BusinessInfo
            {
            }
        }

        /// <summary>
        /// 获取或设置商户列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.BusinessInfo[] BusinessList { get; set; } = default!;
    }
}
