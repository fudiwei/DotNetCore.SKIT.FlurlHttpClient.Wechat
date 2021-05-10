using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /pay/transactions/h5 接口的请求。</para>
    /// </summary>
    public class CreatePayTransactionH5Request : WechatTenpayRequest
    {
        public static class Types
        {
            public class Amount : CreatePayTransactionAppRequest.Types.Amount
            {
            }

            public class Detail : CreatePayTransactionAppRequest.Types.Detail
            {
            }

            public class Scene : CreatePayTransactionAppRequest.Types.Scene
            {
                public static new class Types
                {
                    public class H5
                    {
                        /// <summary>
                        /// 获取或设置场景类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public string Type { get; set; } = "Wap";

                        /// <summary>
                        /// 获取或设置应用名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("app_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("app_name")]
                        public string? AppName { get; set; }

                        /// <summary>
                        /// 获取或设置网站 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("app_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("app_url")]
                        public string? AppUrl { get; set; }

                        /// <summary>
                        /// 获取或设置 iOS 平台 BundleID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("bundle_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("bundle_id")]
                        public string? BundleId { get; set; }

                        /// <summary>
                        /// 获取或设置 Android 平台 PackageName。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("package_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("package_name")]
                        public string? PackageName { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置 H5 场景信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("h5_info")]
                [System.Text.Json.Serialization.JsonPropertyName("h5_info")]
                public Types.H5 H5 { get; set; } = new Types.H5();
            }

            public class Settlement : CreatePayTransactionAppRequest.Types.Settlement
            {
            }
        }

        /// <summary>
        /// 获取或设置微信商户号。如果不指定将使用构造 <see cref="WechatTenpayClient"/> 时的 <see cref="WechatTenpayClientOptions.MerchantId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public virtual string? MerchantId { get; set; }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public virtual string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string OutTradeNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置交易结束时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_expire")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("time_expire")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        public DateTimeOffset? ExpireTime { get; set; }

        /// <summary>
        /// 获取或设置附加数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attach")]
        [System.Text.Json.Serialization.JsonPropertyName("attach")]
        public string? Attachment { get; set; }

        /// <summary>
        /// 获取或设置回调通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string? NotifyUrl { get; set; }

        /// <summary>
        /// 获取或设置订单优惠标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_tag")]
        [System.Text.Json.Serialization.JsonPropertyName("goods_tag")]
        public string? GoodsTag { get; set; }

        /// <summary>
        /// 获取或设置金额信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public Types.Amount Amount { get; set; } = new Types.Amount();

        /// <summary>
        /// 获取或设置商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detail")]
        [System.Text.Json.Serialization.JsonPropertyName("detail")]
        public Types.Detail? Detail { get; set; }

        /// <summary>
        /// 获取或设置场景信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_info")]
        [System.Text.Json.Serialization.JsonPropertyName("scene_info")]
        public Types.Scene Scene { get; set; } = new Types.Scene();

        /// <summary>
        /// 获取或设置结算信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settle_info")]
        [System.Text.Json.Serialization.JsonPropertyName("settle_info")]
        public Types.Settlement? Settlement { get; set; }
    }
}
