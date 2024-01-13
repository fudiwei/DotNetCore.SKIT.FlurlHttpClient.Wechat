namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/logistics/ewaybill/biz/template/getbyid 接口的响应。</para>
    /// </summary>
    public class ChannelsECLogisticsEWaybillTemplateGetByIdResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Template : ChannelsECLogisticsEWaybillTemplateGetResponse.Types.Template
            {
            }
        }

        /// <summary>
        /// 获取或设置模板信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_info")]
        [System.Text.Json.Serialization.JsonPropertyName("template_info")]
        public Types.Template Template { get; set; } = default!;
    }
}
