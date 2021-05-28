using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/local/business/shop/get 接口的响应。</para>
    /// </summary>
    public class CgibinExpressLocalBusinessShopGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Shop
            {
                /// <summary>
                /// 获取或设置配送公司 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_id")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
                public string DeliveryId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商家 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shopid")]
                [System.Text.Json.Serialization.JsonPropertyName("shopid")]
                public string ShopId { get; set; } = default!;

                /// <summary>
                /// 获取或设置审核结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_result")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_result")]
                public int AuditResult { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置运力返回的错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resultcode")]
        [System.Text.Json.Serialization.JsonPropertyName("resultcode")]
        public int ResultCode { get; set; }

        /// <summary>
        /// 获取或设置运力返回的错误描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resultmsg")]
        [System.Text.Json.Serialization.JsonPropertyName("resultmsg")]
        public string ResultMessage { get; set; } = default!;

        /// <summary>
        /// 获取或设置绑定的商家签约账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_list")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_list")]
        public Types.Shop[] ShopList { get; set; } = default!;

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && ResultCode == 0;
        }
    }
}
