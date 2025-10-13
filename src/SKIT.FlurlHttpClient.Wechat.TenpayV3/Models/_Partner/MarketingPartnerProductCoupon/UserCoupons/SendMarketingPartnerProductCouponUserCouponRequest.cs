using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/partner/product-coupon/users/{openid}/coupons 接口的请求。</para>
    /// </summary>
    public class SendMarketingPartnerProductCouponUserCouponRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class TagInfo
            {
                public static class Types
                {
                    public class MemberTag
                    {
                        /// <summary>
                        /// 获取或设置会员卡模板 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("member_card_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("member_card_id")]
                        public string MemberCardId { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// 获取或设置用户商品券标签列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_tag_list")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_tag_list")]
                public IList<string>? CouponTagList { get; set; }

                /// <summary>
                /// 获取或设置会员标签信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("member_tag_info")]
                [System.Text.Json.Serialization.JsonPropertyName("member_tag_info")]
                public Types.MemberTag? MemberTag { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商品券 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_coupon_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_coupon_id")]
        public string ProductCouponId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public string BrandId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置批次 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_id")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_id")]
        public string StockId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置券 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_code")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_code")]
        public string? CouponCode { get; set; }

        /// <summary>
        /// 获取或设置商户请求单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("send_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("send_request_no")]
        public string OutRequestNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置附加信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attach")]
        [System.Text.Json.Serialization.JsonPropertyName("attach")]
        public string? Attachment { get; set; }

        /// <summary>
        /// 获取或设置标签信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_tag_info")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_tag_info")]
        public Types.TagInfo? TagInfo { get; set; }
    }
}
