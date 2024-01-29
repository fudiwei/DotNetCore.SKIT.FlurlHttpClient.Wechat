namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /datacube/getcardmembercarddetail 接口的响应。</para>
    /// </summary>
    public class DataCubeGetCardMemberCardDetailResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data : DataCubeGetCardMemberCardInfoResponse.Types.Data
            {
                /// <summary>
                /// 获取或设置卡券模板编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cardid")]
                [System.Text.Json.Serialization.JsonPropertyName("cardid")]
                public string CardId { get; set; } = default!;

                /// <summary>
                /// 获取或设置子商户类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchanttype")]
                [System.Text.Json.Serialization.JsonPropertyName("merchanttype")]
                public int? SubMerchantType { get; set; }

                /// <summary>
                /// 获取或设置子商户类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("submerchantid")]
                [System.Text.Json.Serialization.JsonPropertyName("submerchantid")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringConverter))]
                public string? SubMerchantId { get; set; }

                /// <summary>
                /// 获取或设置新用户数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("new_user")]
                [System.Text.Json.Serialization.JsonPropertyName("new_user")]
                public int NewUserCount { get; set; }

                /// <summary>
                /// 获取或设置应收金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payOriginalFee")]
                [System.Text.Json.Serialization.JsonPropertyName("payOriginalFee")]
                public int PayOriginalFee { get; set; }

                /// <summary>
                /// 获取或设置实收金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fee")]
                [System.Text.Json.Serialization.JsonPropertyName("fee")]
                public int Fee { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.Data[] DataList { get; set; } = default!;
    }
}
