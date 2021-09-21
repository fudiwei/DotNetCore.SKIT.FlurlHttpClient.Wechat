using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/delivery/open_msg/follow_waybill 接口的请求。</para>
    /// </summary>
    public class CgibinExpressDeliveryOpenMessageFollowWaybillRequest : WechatApiRequest
    {
        public static class Types
        {
            public class Goods
            {
                public static class Types
                {
                    public class Detail
                    {
                        /// <summary>
                        /// 获取或设置商品名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods_name")]
                        public string GoodsName { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置商品图片 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods_img_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods_img_url")]
                        public string GoodsImageUrl { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置商品详情描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods_desc")]
                        public string? GoodsDescription { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商品详情列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("detail_list")]
                [System.Text.Json.Serialization.JsonPropertyName("detail_list")]
                public IList<Types.Detail> DetailList { get; set; } = new List<Types.Detail>();
            }
        }

        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置运单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
        public string WaybillId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置寄件人电话号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sender_phone")]
        [System.Text.Json.Serialization.JsonPropertyName("sender_phone")]
        public string? SenderPhoneNumber { get; set; }

        /// <summary>
        /// 获取或设置收件人电话号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receiver_phone")]
        [System.Text.Json.Serialization.JsonPropertyName("receiver_phone")]
        public string? ReceiverPhoneNumber { get; set; }

        /// <summary>
        /// 获取或设置商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_info")]
        [System.Text.Json.Serialization.JsonPropertyName("goods_info")]
        public Types.Goods? Goods { get; set; }

        /// <summary>
        /// 获取或设置微信交易单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trans_id")]
        [System.Text.Json.Serialization.JsonPropertyName("trans_id")]
        public string? TransactionId { get; set; }

        /// <summary>
        /// 获取或设置落地页商品卡片跳转路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_detail_path")]
        [System.Text.Json.Serialization.JsonPropertyName("order_detail_path")]
        public string? OrderDetailPagePath { get; set; }
    }
}
