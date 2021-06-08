using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /nontax/insertbill 接口的请求。</para>
    /// </summary>
    public class NontaxInsertBillRequest : WechatApiRequest
    {
        public static class Types
        {
            public class CardExtra
            {
                public static class Types
                {
                    public class BillCard
                    {
                        public static class Types
                        {
                            public class Bill
                            {
                                /// <summary>
                                /// 获取或设置财政电子票据抬头。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("title")]
                                [System.Text.Json.Serialization.JsonPropertyName("title")]
                                public string Title { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置财政电子票据金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("fee")]
                                [System.Text.Json.Serialization.JsonPropertyName("fee")]
                                public int Fee { get; set; }

                                /// <summary>
                                /// 获取或设置财政电子票据号码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("billing_no")]
                                [System.Text.Json.Serialization.JsonPropertyName("billing_no")]
                                public string BillNumber { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置财政电子票据代码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("billing_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("billing_code")]
                                public string BillCode { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置开票时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("billing_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("billing_time")]
                                public long DateTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置财政电子票据文件标识。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("s_pdf_media_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("s_pdf_media_id")]
                                public string PdfSpMediaId { get; set; } = string.Empty;
                            }
                        }

                        /// <summary>
                        /// 获取或设置非税票据信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("invoice_user_data")]
                        [System.Text.Json.Serialization.JsonPropertyName("invoice_user_data")]
                        public Types.Bill Bill { get; set; } = new Types.Bill();
                    }
                }

                /// <summary>
                /// 获取或设置用户信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_card")]
                [System.Text.Json.Serialization.JsonPropertyName("user_card")]
                public Types.BillCard BillCard { get; set; } = new Types.BillCard();
            }
        }

        /// <summary>
        /// 获取或设置订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信 AppId。如果不指定将使用构造 <see cref="WechatApiClient"/> 时的 <see cref="WechatApiClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置非税票据卡券模板编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string CardId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置非税票据扩展信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_ext")]
        [System.Text.Json.Serialization.JsonPropertyName("card_ext")]
        public Types.CardExtra CardExtra { get; set; } = new Types.CardExtra();
    }
}
