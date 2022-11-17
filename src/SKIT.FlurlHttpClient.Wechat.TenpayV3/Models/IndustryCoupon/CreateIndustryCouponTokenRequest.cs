using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /industry-coupon/tokens 接口的请求。</para>
    /// </summary>
    public class CreateIndustryCouponTokenRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Coupon
            {
                /// <summary>
                /// 获取或设置批次号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_id")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_id")]
                public int StockId { get; set; }

                /// <summary>
                /// 获取或设置券 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_id")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_id")]
                public string CouponId { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置券列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_list")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_list")]
        public IList<Types.Coupon> CouponList { get; set; } = new List<Types.Coupon>();
    }
}
