using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/business/order/add 接口的响应。</para>
    /// </summary>
    public class CgibinExpressBusinessOrderAddResponse : WechatApiResponse
    {
        public static class Types
        {
            public class WaybillData : CgibinExpressBusinessOrderGetResponse.Types.WaybillData
            {
            }
        }

        /// <summary>
        /// 获取或设置快递侧错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_resultcode")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_resultcode")]
        public int? ResultCode { get; set; }

        /// <summary>
        /// 获取或设置快递侧错误信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_resultmsg")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_resultmsg")]
        public string? ResultMessage { get; set; }

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置运单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
        public string WaybillId { get; set; } = default!;

        /// <summary>
        /// 获取或设置运单数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_data")]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_data")]
        public Types.WaybillData[] WaybillDataList { get; set; } = default!;

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && ResultCode.GetValueOrDefault() == 0;
        }
    }
}
