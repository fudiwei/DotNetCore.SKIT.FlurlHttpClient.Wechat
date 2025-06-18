namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/operationams?action=agency_get_adunit_list 接口的响应。</para>
    /// </summary>
    public class WxaOperationAMSAgencyGetAdUnitListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class AdUnit
            {
                public static class Types
                {
                    public class Size
                    {
                        /// <summary>
                        /// 获取或设置宽度（单位：宽度）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("width")]
                        [System.Text.Json.Serialization.JsonPropertyName("width")]
                        public int Width { get; set; }

                        /// <summary>
                        /// 获取或设置高度（单位：宽度）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("height")]
                        [System.Text.Json.Serialization.JsonPropertyName("height")]
                        public int Height { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置广告单元 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ad_unit_id")]
                [System.Text.Json.Serialization.JsonPropertyName("ad_unit_id")]
                public string AdUnitId { get; set; } = default!;

                /// <summary>
                /// 获取或设置广告单元名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ad_unit_name")]
                [System.Text.Json.Serialization.JsonPropertyName("ad_unit_name")]
                public string AdUnitName { get; set; } = default!;

                /// <summary>
                /// 获取或设置广告位类型 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("slot_id")]
                [System.Text.Json.Serialization.JsonPropertyName("slot_id")]
                public string? AdSlotId { get; set; }

                /// <summary>
                /// 获取或设置广告位类型名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ad_slot")]
                [System.Text.Json.Serialization.JsonPropertyName("ad_slot")]
                public string? AdSlot { get; set; }

                /// <summary>
                /// 获取或设置广告单元类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ad_unit_type")]
                [System.Text.Json.Serialization.JsonPropertyName("ad_unit_type")]
                public string Type { get; set; } = default!;

                /// <summary>
                /// 获取或设置开关状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ad_unit_status")]
                [System.Text.Json.Serialization.JsonPropertyName("ad_unit_status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置尺寸列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ad_unit_size")]
                [System.Text.Json.Serialization.JsonPropertyName("ad_unit_size")]
                public Types.Size[]? SizeList { get; set; }

                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string? AppId { get; set; }

                /// <summary>
                /// 获取或设置广告展示时长最小值（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video_duration_min")]
                [System.Text.Json.Serialization.JsonPropertyName("video_duration_min")]
                public int? MinVideoDuration { get; set; }

                /// <summary>
                /// 获取或设置广告展示时长最大值（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video_duration_max")]
                [System.Text.Json.Serialization.JsonPropertyName("video_duration_max")]
                public int? MaxVideoDuration { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ret")]
        [System.Text.Json.Serialization.JsonPropertyName("ret")]
        public int ReturnCode { get; set; }

        /// <summary>
        /// 获取或设置返回错误信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
        public string? ReturnMessage { get; set; }

        /// <summary>
        /// 获取或设置广告单元列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ad_unit")]
        [System.Text.Json.Serialization.JsonPropertyName("ad_unit")]
        public Types.AdUnit[] AdUnitList { get; set; } = default!;

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int TotalCount { get; set; }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && ReturnCode == 0;
        }
    }
}
