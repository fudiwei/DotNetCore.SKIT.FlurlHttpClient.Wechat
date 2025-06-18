namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/brand/update 接口的请求。</para>
    /// </summary>
    public class ChannelsECBrandUpdateRequest : WechatApiRequest, IInferable<ChannelsECBrandUpdateRequest, ChannelsECBrandUpdateResponse>
    {
        public static class Types
        {
            public class Brand
            {
                public static class Types
                {
                    public class RegisterDetail : ChannelsECBrandAddRequest.Types.Brand.Types.RegisterDetail
                    {
                    }

                    public class ApplicationDetail : ChannelsECBrandAddRequest.Types.Brand.Types.ApplicationDetail
                    {
                    }

                    public class GrantDetail : ChannelsECBrandAddRequest.Types.Brand.Types.GrantDetail
                    {
                    }
                }

                /// <summary>
                /// 获取或设置品牌 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand_id")]
                [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
                public long BrandId { get; set; }

                /// <summary>
                /// 获取或设置品牌商标中文名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ch_name")]
                [System.Text.Json.Serialization.JsonPropertyName("ch_name")]
                public string? ChineseName { get; set; }

                /// <summary>
                /// 获取或设置品牌商标英文名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("en_name")]
                [System.Text.Json.Serialization.JsonPropertyName("en_name")]
                public string? EnglishName { get; set; }

                /// <summary>
                /// 获取或设置商标分类号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("classification_no")]
                [System.Text.Json.Serialization.JsonPropertyName("classification_no")]
                public string ClassificationNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商标类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("trade_mark_symbol")]
                [System.Text.Json.Serialization.JsonPropertyName("trade_mark_symbol")]
                public int TradeMarkSymbol { get; set; }

                /// <summary>
                /// 获取或设置商标注册详细信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("register_details")]
                [System.Text.Json.Serialization.JsonPropertyName("register_details")]
                public Types.RegisterDetail RegisterDetail { get; set; } = new Types.RegisterDetail();

                /// <summary>
                /// 获取或设置商标申请详细信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("application_details")]
                [System.Text.Json.Serialization.JsonPropertyName("application_details")]
                public Types.ApplicationDetail ApplicationDetail { get; set; } = new Types.ApplicationDetail();

                /// <summary>
                /// 获取或设置商标授权类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("grant_type")]
                [System.Text.Json.Serialization.JsonPropertyName("grant_type")]
                public int? GrantType { get; set; }

                /// <summary>
                /// 获取或设置商标授权详细信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("grant_details")]
                [System.Text.Json.Serialization.JsonPropertyName("grant_details")]
                public Types.GrantDetail GrantDetail { get; set; } = new Types.GrantDetail();
            }
        }

        /// <summary>
        /// 获取或设置品牌信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand")]
        [System.Text.Json.Serialization.JsonPropertyName("brand")]
        public Types.Brand Brand { get; set; } = new Types.Brand();
    }
}
