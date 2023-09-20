using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/intracity/addorder 接口的请求。</para>
    /// </summary>
    public class CgibinExpressIntracityAddOrderRequest : WechatApiRequest, IInferable<CgibinExpressIntracityAddOrderRequest, CgibinExpressIntracityAddOrderResponse>
    {
        public static class Types
        {
            public class CargoInfo : CgibinExpressIntracityPreAddOrderRequest.Types.CargoInfo
            {
                public static class Types
                {
                    public class Item
                    {
                        /// <summary>
                        /// 获取或设置物品名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_name")]
                        public string ItemName { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置物品图片 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_pic_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_pic_url")]
                        public string ItemPictureUrl { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置物品数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("count")]
                        [System.Text.Json.Serialization.JsonPropertyName("count")]
                        public int ItemCount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置物品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_list")]
                [System.Text.Json.Serialization.JsonPropertyName("item_list")]
                public IList<Types.Item> ItemList { get; set; } = new List<Types.Item>();
            }
        }

        /// <summary>
        /// 获取或设置微信门店编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wx_store_id")]
        [System.Text.Json.Serialization.JsonPropertyName("wx_store_id")]
        public string StoreId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置门店订单编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("store_order_id")]
        public string StoreOrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置收件人 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("user_openid")]
        public string UserOpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置收件人姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_name")]
        [System.Text.Json.Serialization.JsonPropertyName("user_name")]
        public string UserName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置收件人手机号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_phone")]
        [System.Text.Json.Serialization.JsonPropertyName("user_phone")]
        public string UserPhoneNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置收件用户位置经度。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_lng")]
        [System.Text.Json.Serialization.JsonPropertyName("user_lng")]
        public double UserLongitude { get; set; }

        /// <summary>
        /// 获取或设置收件用户位置维度。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_lat")]
        [System.Text.Json.Serialization.JsonPropertyName("user_lat")]
        public double UserLatitude { get; set; }

        /// <summary>
        /// 获取或设置收件用户详细地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_address")]
        [System.Text.Json.Serialization.JsonPropertyName("user_address")]
        public string UserAddress { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置订单序号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_seq")]
        [System.Text.Json.Serialization.JsonPropertyName("order_seq")]
        public string? OrderSequence { get; set; }

        /// <summary>
        /// 获取或设置验证码类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("verify_code_type")]
        [System.Text.Json.Serialization.JsonPropertyName("verify_code_type")]
        public int? VerifyCodeType { get; set; }

        /// <summary>
        /// 获取或设置跳转商家订单页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_detail_path")]
        [System.Text.Json.Serialization.JsonPropertyName("order_detail_path")]
        public string? OrderDetailPagePath { get; set; }

        /// <summary>
        /// 获取或设置回调地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("callback_url")]
        [System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// 获取或设置商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cargo")]
        [System.Text.Json.Serialization.JsonPropertyName("cargo")]
        public Types.CargoInfo CargoInfo { get; set; } = new Types.CargoInfo();

        /// <summary>
        /// 获取或设置是否使用沙箱。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("use_sandbox")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("use_sandbox")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsSandbox { get; set; }
    }
}
