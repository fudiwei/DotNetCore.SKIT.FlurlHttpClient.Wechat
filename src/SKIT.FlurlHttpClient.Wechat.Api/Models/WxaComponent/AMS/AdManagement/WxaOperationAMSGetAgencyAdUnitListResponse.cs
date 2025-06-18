namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/operationams?action=get_agency_ad_unit_list 接口的响应。</para>
    /// </summary>
    public class WxaOperationAMSGetAgencyAdUnitListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Template
            {
                public static class Types
                {
                    public class AdUnit : WxaOperationAMSAgencyGetAdUnitListResponse.Types.AdUnit
                    {
                    }
                }

                /// <summary>
                /// 获取或设置模板 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tmpl_id")]
                [System.Text.Json.Serialization.JsonPropertyName("tmpl_id")]
                public string TemplateId { get; set; } = default!;

                /// <summary>
                /// 获取或设置广告单元名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ad_unit_name")]
                [System.Text.Json.Serialization.JsonPropertyName("ad_unit_name")]
                public string Name { get; set; } = default!;

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
                /// 获取或设置绑定的商户广告单元数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tmpl_bind_total_num")]
                [System.Text.Json.Serialization.JsonPropertyName("tmpl_bind_total_num")]
                public int AdUnitTotalCount { get; set; }

                /// <summary>
                /// 获取或设置绑定的商户广告单元列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tmpl_bind_list")]
                [System.Text.Json.Serialization.JsonPropertyName("tmpl_bind_list")]
                public Types.AdUnit[]? AdUnitList { get; set; }
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
        /// 获取或设置模板列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ad_unit_list")]
        [System.Text.Json.Serialization.JsonPropertyName("ad_unit_list")]
        public Types.Template[] TemplateList { get; set; } = default!;

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
