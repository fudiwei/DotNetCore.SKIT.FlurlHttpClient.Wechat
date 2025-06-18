namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/addguidebuyerrelation 接口的响应。</para>
    /// </summary>
    public class CgibinGuideAddGuideBuyerRelationResponse : WechatApiResponse
    {
        public static class Types
        {
            public class BuyerResponse
            {
                /// <summary>
                /// 获取或设置错误码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errcode")]
                [System.Text.Json.Serialization.JsonPropertyName("errcode")]
                public int ErrorCode { get; set; }

                /// <summary>
                /// 获取或设置错误信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errmsg")]
                [System.Text.Json.Serialization.JsonPropertyName("errmsg")]
                public string ErrorMessage { get; set; } = default!;

                /// <summary>
                /// 获取或设置客户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置客户绑定结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("buyer_resp")]
        [System.Text.Json.Serialization.JsonPropertyName("buyer_resp")]
        public Types.BuyerResponse[]? BuyerResponseList { get; set; }
    }
}
