namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/sharer/bind 接口的响应。</para>
    /// </summary>
    public class ShopSharerBindResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Result
            {
                /// <summary>
                /// 获取或设置分享员 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置邀请结果代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("result_code")]
                [System.Text.Json.Serialization.JsonPropertyName("result_code")]
                public int ResultCode { get; set; }

                /// <summary>
                /// 获取或设置邀请错误原因代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reason_code")]
                [System.Text.Json.Serialization.JsonPropertyName("reason_code")]
                public int ReasonCode { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置绑定成功的分享员 OpenId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success_list")]
        [System.Text.Json.Serialization.JsonPropertyName("success_list")]
        public string[] SuccessOpenIdList { get; set; } = default!;

        /// <summary>
        /// 获取或设置绑定失败的分享员 OpenId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_list")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_list")]
        public string[] FailOpenIdList { get; set; } = default!;

        /// <summary>
        /// 获取或设置绑定拒绝的分享员 OpenId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refuse_list")]
        [System.Text.Json.Serialization.JsonPropertyName("refuse_list")]
        public string[] RefuseOpenIdList { get; set; } = default!;

        /// <summary>
        /// 获取或设置绑定结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result_list")]
        [System.Text.Json.Serialization.JsonPropertyName("result_list")]
        public Types.Result[] ResultList { get; set; } = default!;
    }
}
