namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/invoice/platform/createcard 接口的请求。</para>
    /// </summary>
    public class CardInvoicePlatformCreateCardRequest : WechatApiRequest, IMapResponse<CardInvoicePlatformCreateCardRequest, CardInvoicePlatformCreateCardResponse>
    {
        public static class Types
        {
            public class InvoiceTemplate
            {
                public static class Types
                {
                    public class Base
                    {
                        /// <summary>
                        /// 获取或设置商家 Logo URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("logo_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("logo_url")]
                        public string LogoUrl { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置商家简称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置开票平台自定义入口名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("custom_url_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("custom_url_name")]
                        public string? CustomUrlTitle { get; set; }

                        /// <summary>
                        /// 获取或设置开票平台自定义入口右侧提示信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("custom_url_sub_title")]
                        [System.Text.Json.Serialization.JsonPropertyName("custom_url_sub_title")]
                        public string? CustomUrlSubTitle { get; set; }

                        /// <summary>
                        /// 获取或设置开票平台自定义入口 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("custom_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("custom_url")]
                        public string? CustomUrl { get; set; }

                        /// <summary>
                        /// 获取或设置营销场景的自定义入口名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promotion_url_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("promotion_url_name")]
                        public string? PromotionUrlTitle { get; set; }

                        /// <summary>
                        /// 获取或设置营销场景的自定义入口右侧提示信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promotion_url_sub_title")]
                        [System.Text.Json.Serialization.JsonPropertyName("promotion_url_sub_title")]
                        public string? PromotionUrlSubTitle { get; set; }

                        /// <summary>
                        /// 获取或设置营销场景的自定义入口 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promotion_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("promotion_url")]
                        public string? PromotionUrl { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置发票基础信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base_info")]
                [System.Text.Json.Serialization.JsonPropertyName("base_info")]
                public Types.Base Base { get; set; } = new Types.Base();

                /// <summary>
                /// 获取或设置开票类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string Type { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置开票方全称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payee")]
                [System.Text.Json.Serialization.JsonPropertyName("payee")]
                public string Payee { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置发票模板信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invoice_info")]
        [System.Text.Json.Serialization.JsonPropertyName("invoice_info")]
        public Types.InvoiceTemplate InvoiceTemplate { get; set; } = new Types.InvoiceTemplate();
    }
}
