namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/delguidebuyerrelation 接口的响应。</para>
    /// </summary>
    public class CgibinGuideDeleteGuideBuyerRelationResponse : WechatApiResponse
    {
        public static class Types
        {
            public class BuyerResponse : CgibinGuideAddGuideBuyerRelationResponse.Types.BuyerResponse
            {
            }
        }

        /// <summary>
        /// 获取或设置客户移除结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("buyer_resp")]
        [System.Text.Json.Serialization.JsonPropertyName("buyer_resp")]
        public Types.BuyerResponse[]? BuyerResponseList { get; set; }
    }
}
