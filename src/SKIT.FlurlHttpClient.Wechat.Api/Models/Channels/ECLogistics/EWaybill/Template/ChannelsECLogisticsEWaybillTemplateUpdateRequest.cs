using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/logistics/ewaybill/biz/template/update 接口的请求。</para>
    /// </summary>
    public class ChannelsECLogisticsEWaybillTemplateUpdateRequest : WechatApiRequest, IInferable<ChannelsECLogisticsEWaybillTemplateUpdateRequest, ChannelsECLogisticsEWaybillTemplateUpdateResponse>
    {
        public static class Types
        {
            public class Template : ChannelsECLogisticsEWaybillTemplateCreateRequest.Types.Template
            {
                public static new class Types
                {
                    public class Option : ChannelsECLogisticsEWaybillTemplateCreateRequest.Types.Template.Types.Option
                    {
                    }
                }

                /// <summary>
                /// 获取或设置模板 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_id")]
                [System.Text.Json.Serialization.JsonPropertyName("template_id")]
                public string TemplateId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置模板信息选项。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("options")]
                [System.Text.Json.Serialization.JsonPropertyName("options")]
                public new IList<Types.Option> Options { get; set; } = new List<Types.Option>();
            }
        }

        /// <summary>
        /// 获取或设置快递公司 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_id")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
        public string DeliveryId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置模板信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info")]
        [System.Text.Json.Serialization.JsonPropertyName("info")]
        public Types.Template Template { get; set; } = new Types.Template();
    }
}
