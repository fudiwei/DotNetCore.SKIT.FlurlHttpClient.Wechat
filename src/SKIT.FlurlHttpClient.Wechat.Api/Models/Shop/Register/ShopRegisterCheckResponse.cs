using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/register/check 接口的响应。</para>
    /// </summary>
    public class ShopRegisterCheckResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Access
                    {
                        /// <summary>
                        /// 获取或设置上传商品并审核成功状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("spu_audit_success")]
                        [System.Text.Json.Serialization.JsonPropertyName("spu_audit_success")]
                        public int SPUAuditStatus { get; set; }

                        /// <summary>
                        /// 获取或设置发起一笔订单并支付成功状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_order_success")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_order_success")]
                        public int PayOrderStatus { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置审核状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置接入相关信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("access_info")]
                [System.Text.Json.Serialization.JsonPropertyName("access_info")]
                public Types.Access? Access { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
