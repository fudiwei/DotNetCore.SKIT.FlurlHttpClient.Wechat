using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/aftersale/syncworkorder 接口的请求。</para>
    /// </summary>
    public class ChannelsECAftersaleSyncWorkOrderRequest : WechatApiRequest, IInferable<ChannelsECAftersaleSyncWorkOrderRequest, ChannelsECAftersaleSyncWorkOrderResponse>
    {
        public static class Types
        {
            public class WorkOrder
            {
                public static class Types
                {
                    public class Item
                    {
                        public static class Types
                        {
                            public class MediaInfo
                            {
                                public static class Types
                                {
                                    public class Picture
                                    {
                                        /// <summary>
                                        /// 获取或设置媒体文件 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("tmp_media_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("tmp_media_id")]
                                        public string MediaId { get; set; } = string.Empty;
                                    }
                                }

                                /// <summary>
                                /// 获取或设置媒体文件类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("type")]
                                [System.Text.Json.Serialization.JsonPropertyName("type")]
                                public int MediaType { get; set; }

                                /// <summary>
                                /// 获取或设置图片信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("picture")]
                                [System.Text.Json.Serialization.JsonPropertyName("picture")]
                                public Types.Picture? Picture { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置工单状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置工单描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("desc")]
                        public string Description { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置更新时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("update_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                        public long UpdateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置终态结果类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("result_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("result_type")]
                        public int ResultType { get; set; }

                        /// <summary>
                        /// 获取或设置退款金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_amount")]
                        public int? RefundAmount { get; set; }

                        /// <summary>
                        /// 获取或设置媒体文件列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("media_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("media_list")]
                        public IList<Types.MediaInfo>? MediaList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置工单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("work_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("work_order_id")]
                public string WorkOrderId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置递增版本号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("version")]
                [System.Text.Json.Serialization.JsonPropertyName("version")]
                public int Version { get; set; }

                /// <summary>
                /// 获取或设置工单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("items")]
                [System.Text.Json.Serialization.JsonPropertyName("items")]
                public IList<Types.Item>? ItemList { get; set; } = new List<Types.Item>();
            }
        }

        /// <summary>
        /// 获取或设置纠纷单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("complaint_id")]
        [System.Text.Json.Serialization.JsonPropertyName("complaint_id")]
        public string ComplaintId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置工单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("work_order_info")]
        [System.Text.Json.Serialization.JsonPropertyName("work_order_info")]
        public Types.WorkOrder WorkOrder { get; set; } = new Types.WorkOrder();
    }
}
