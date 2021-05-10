using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /combine-transactions/h5 接口的请求。</para>
    /// </summary>
    public class CreateCombineTransactionH5Request : WechatTenpayRequest
    {
        public static class Types
        {
            public class SubOrder : CreateCombineTransactionAppRequest.Types.SubOrder
            {
            }

            public class Scene : CreateCombineTransactionAppRequest.Types.Scene
            {
                public static class Types
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
        }

        /// <summary>
        /// 获取或设置合单发起方的微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("combine_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("combine_appid")]
        public string CombineAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置合单发起方的微信商户号。如果不指定将使用构造 <see cref="WechatTenpayClient"/> 时的 <see cref="WechatTenpayClientOptions.MerchantId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("combine_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("combine_mchid")]
        public string? CombineMerchantId { get; set; }

        /// <summary>
        /// 获取或设置合单商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("combine_out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("combine_out_trade_no")]
        public string CombineOutTradeNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置交易起始时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_start")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("time_start")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        public DateTimeOffset? StartTime { get; set; }

        /// <summary>
        /// 获取或设置交易结束时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_expire")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("time_expire")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        public DateTimeOffset? ExpireTime { get; set; }

        /// <summary>
        /// 获取或设置回调通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string? NotifyUrl { get; set; }

        /// <summary>
        /// 获取或设置子单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_orders")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_orders")]
        public IList<Types.SubOrder> SubOrderList { get; set; } = new List<Types.SubOrder>();

        /// <summary>
        /// 获取或设置场景信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_info")]
        [System.Text.Json.Serialization.JsonPropertyName("scene_info")]
        public Types.Scene? Scene { get; set; }
    }
}
