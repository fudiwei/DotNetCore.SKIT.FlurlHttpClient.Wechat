using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/dropship/supplier/delivery/update 接口的请求。</para>
    /// </summary>
    public class ChannelsECOrderDropshipSupplierDeliveryUpdateRequest : WechatApiRequest, IInferable<ChannelsECOrderDropshipSupplierDeliveryUpdateRequest, ChannelsECOrderDropshipSupplierDeliveryUpdateResponse>
    {
        public static class Types
        {
            public class ChangeInfo
            {
                public static class Types
                {
                    public class Delivery : ChannelsECOrderDropshipSupplierDeliverySendRequest.Types.Delivery
                    {
                    }
                }

                /// <summary>
                /// 获取或设置旧快递信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("old")]
                [System.Text.Json.Serialization.JsonPropertyName("old")]
                public Types.Delivery OldDelivery { get; set; } = new Types.Delivery();

                /// <summary>
                /// 获取或设置新快递信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("new")]
                [System.Text.Json.Serialization.JsonPropertyName("new")]
                public Types.Delivery NewDelivery { get; set; } = new Types.Delivery();
            }
        }

        /// <summary>
        /// 获取或设置代发单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ds_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ds_order_id")]
        public string DropshipOrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置快递修改信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("change_infos")]
        [System.Text.Json.Serialization.JsonPropertyName("change_infos")]
        public IList<Types.ChangeInfo> ChangeInfoList { get; set; } = new List<Types.ChangeInfo>();
    }
}
