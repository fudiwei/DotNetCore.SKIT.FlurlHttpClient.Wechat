namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/aftersale/searchguaranteeorder 接口的响应。</para>
    /// </summary>
    public class ChannelsECAftersaleSearchGuaranteeOrderResponse : WechatApiResponse
    {
        public static class Types
        {
            public class GuaranteeOrder
            {
                public static class Types
                {
                    public class ProductInfo
                    {
                        /// <summary>
                        /// 获取或设置商品名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品缩略图 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("thumb_img")]
                        [System.Text.Json.Serialization.JsonPropertyName("thumb_img")]
                        public string ThumbnailUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品详情。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("detail")]
                        [System.Text.Json.Serialization.JsonPropertyName("detail")]
                        public string? Detail { get; set; }

                        /// <summary>
                        /// 获取或设置商品价格（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("real_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("real_price")]
                        public int RealPrice { get; set; }

                        /// <summary>
                        /// 获取或设置商品数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_cnt")]
                        public int Count { get; set; }
                    }

                    public class PayInfo
                    {
                        /// <summary>
                        /// 获取或设置微信交易单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("transaction_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
                        public string TransactionId { get; set; } = default!;
                    }

                    public class PresentInfo
                    {
                        /// <summary>
                        /// 获取或设置礼物单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("present_order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("present_order_id")]
                        public string PresentOrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置送礼微信昵称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("giver_nickname")]
                        [System.Text.Json.Serialization.JsonPropertyName("giver_nickname")]
                        public string GiverNickname { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置收礼时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("accept_present_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("accept_present_time")]
                        public long AcceptPresentTimestamp { get; set; }
                    }

                    public class Fake1Pay4Info
                    {
                        /// <summary>
                        /// 获取或设置鉴定费用（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("identify_fee")]
                        [System.Text.Json.Serialization.JsonPropertyName("identify_fee")]
                        public int? IdentifyFee { get; set; }

                        /// <summary>
                        /// 获取或设置商品费用（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_fee")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_fee")]
                        public int ProductFee { get; set; }

                        /// <summary>
                        /// 获取或设置预计赔付金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_pay_fee")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_pay_fee")]
                        public int? TotalPayFee { get; set; }

                        /// <summary>
                        /// 获取或设置最终赔付金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("acctual_pay")]
                        [System.Text.Json.Serialization.JsonPropertyName("acctual_pay")]
                        public int? ActualPayFee { get; set; }

                        /// <summary>
                        /// 获取或设置鉴定凭证 MediaId 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("identify_proof_pic_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("identify_proof_pic_list")]
                        public string[]? IdentifyProofPictureMediaIdList { get; set; }

                        /// <summary>
                        /// 获取或设置费用凭证 MediaId 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fee_proof_pic_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("fee_proof_pic_list")]
                        public string[]? FeeProofPictureMediaIdList { get; set; }

                        /// <summary>
                        /// 获取或设置申请原因类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("apply_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("apply_reason")]
                        public int? ApplyReasonType { get; set; }
                    }

                    public class BadPayInfo
                    {
                        /// <summary>
                        /// 获取或设置损坏程度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("bad_level")]
                        [System.Text.Json.Serialization.JsonPropertyName("bad_level")]
                        public int BadLevel { get; set; }

                        /// <summary>
                        /// 获取或设置损坏凭证文字。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("content")]
                        [System.Text.Json.Serialization.JsonPropertyName("content")]
                        public string Content { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置损坏凭证图片 MediaId 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pic_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("pic_list")]
                        public string[]? PictureMediaList { get; set; }

                        /// <summary>
                        /// 获取或设置赔付金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_fee")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_fee")]
                        public int PayFee { get; set; }

                        /// <summary>
                        /// 获取或设置商家协商损坏程度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("merchant_modify_level")]
                        [System.Text.Json.Serialization.JsonPropertyName("merchant_modify_level")]
                        public int? MerchantModifyLevel { get; set; }

                        /// <summary>
                        /// 获取或设置商家备注。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("merchant_remark")]
                        [System.Text.Json.Serialization.JsonPropertyName("merchant_remark")]
                        public string? MerchantRemark { get; set; }

                        /// <summary>
                        /// 获取或设置平台调整损坏程度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("platform_modify_level")]
                        [System.Text.Json.Serialization.JsonPropertyName("platform_modify_level")]
                        public int? PlatformModifyLevel { get; set; }

                        /// <summary>
                        /// 获取或设置退款类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_type")]
                        public int RefundType { get; set; }

                        /// <summary>
                        /// 获取或设置收货类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("receive_product")]
                        [System.Text.Json.Serialization.JsonPropertyName("receive_product")]
                        public int? ReceiveType { get; set; }

                        /// <summary>
                        /// 获取或设置退款原因类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_reason")]
                        public int? RefundReasonType { get; set; }

                        /// <summary>
                        /// 获取或设置退款原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_reason_text")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_reason_text")]
                        public string? RefundReason { get; set; }

                        /// <summary>
                        /// 获取或设置凭证图片 MediaId 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title_pic_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("title_pic_list")]
                        public string[]? TitleMediaIdList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置保障单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("guarantee_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("guarantee_order_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long c { get; set; }

                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置保障单类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置订单类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_type")]
                [System.Text.Json.Serialization.JsonPropertyName("order_type")]
                public int OrderType { get; set; }

                /// <summary>
                /// 获取或设置售后单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置买家用户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置买家用户 UnionId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("unionid")]
                [System.Text.Json.Serialization.JsonPropertyName("unionid")]
                public string? UnionId { get; set; }

                /// <summary>
                /// 获取或设置申请原因类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("apply_reason_type")]
                [System.Text.Json.Serialization.JsonPropertyName("apply_reason_type")]
                public int ApplyReasonType { get; set; }

                /// <summary>
                /// 获取或设置申请原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("apply_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("apply_reason")]
                public string ApplyReason { get; set; } = default!;

                /// <summary>
                /// 获取或设置保障单过期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_time")]
                [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
                public long ExpireTimestamp { get; set; }

                /// <summary>
                /// 获取或设置保障单完成时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("complete_time")]
                [System.Text.Json.Serialization.JsonPropertyName("complete_time")]
                public long? CompleteTimestamp { get; set; }

                /// <summary>
                /// 获取或设置商品信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_info")]
                [System.Text.Json.Serialization.JsonPropertyName("product_info")]
                public Types.ProductInfo ProductInfo { get; set; } = default!;

                /// <summary>
                /// 获取或设置退款金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_amount")]
                public int PayAmount { get; set; }

                /// <summary>
                /// 获取或设置支付信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_pay_info")]
                [System.Text.Json.Serialization.JsonPropertyName("order_pay_info")]
                public Types.PayInfo PayInfo { get; set; } = default!;

                /// <summary>
                /// 获取或设置小程序会员已经优惠金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wxa_vip_discounted_price")]
                [System.Text.Json.Serialization.JsonPropertyName("wxa_vip_discounted_price")]
                public int? WxaVipDiscountedPrice { get; set; }

                /// <summary>
                /// 获取或设置商家拒绝原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_refuse_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_refuse_reason")]
                public string? MerchantRefuseReason { get; set; }

                /// <summary>
                /// 获取或设置礼物信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_present_info")]
                [System.Text.Json.Serialization.JsonPropertyName("order_present_info")]
                public Types.PresentInfo? PresentInfo { get; set; }

                /// <summary>
                /// 获取或设置假一赔四信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fake_one_pay_four_info")]
                [System.Text.Json.Serialization.JsonPropertyName("fake_one_pay_four_info")]
                public Types.Fake1Pay4Info? Fake1Pay4Info { get; set; }

                /// <summary>
                /// 获取或设置坏损包退信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bad_pay_info")]
                [System.Text.Json.Serialization.JsonPropertyName("bad_pay_info")]
                public Types.BadPayInfo? BadPayInfo { get; set; }

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置保障单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guarantee_order_list")]
        [System.Text.Json.Serialization.JsonPropertyName("guarantee_order_list")]
        public Types.GuaranteeOrder[] GuaranteeOrderList { get; set; } = default!;

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int TotalCount { get; set; }
    }
}
