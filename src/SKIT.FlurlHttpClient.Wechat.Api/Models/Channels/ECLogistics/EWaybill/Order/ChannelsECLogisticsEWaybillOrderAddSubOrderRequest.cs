using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/logistics/ewaybill/biz/order/addsuborder 接口的请求。</para>
    /// </summary>
    public class ChannelsECLogisticsEWaybillOrderAddSubOrderRequest : WechatApiRequest, IInferable<ChannelsECLogisticsEWaybillOrderAddSubOrderRequest, ChannelsECLogisticsEWaybillOrderAddSubOrderResponse>
    {
        public static class Types
        {
            public class SubPackage : ChannelsECLogisticsEWaybillOrderCreateRequest.Types.DeliveryInfo.Types.SubPackage
            {
            }
        }

        /// <summary>
        /// 获取或设置电子面单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ewaybill_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ewaybill_order_id")]
        public string EWaybillOrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置快递单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
        public string WaybillId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置快递公司 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_id")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
        public string DeliveryId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置店铺 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_id")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_id")]
        public string ShopId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置电子面单账号 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ewaybill_acct_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ewaybill_acct_id")]
        public string EWaybillAccountId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置追加面单数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("add_package_quantity")]
        [System.Text.Json.Serialization.JsonPropertyName("add_package_quantity")]
        public int AddPackageQuantity { get; set; }

        /// <summary>
        /// 获取或设置面单模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// 获取或设置子件列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subpackage_list")]
        [System.Text.Json.Serialization.JsonPropertyName("subpackage_list")]
        public IList<Types.SubPackage>? SubPackageList { get; set; }

        /// <summary>
        /// 获取或设置子单额外信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_order_ext_info")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_order_ext_info")]
        public string? SubOrderExtraInfo { get; set; }
    }
}
