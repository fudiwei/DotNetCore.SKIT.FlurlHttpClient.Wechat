namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/merchant/getfreighttemplatedetail 接口的请求。</para>
    /// </summary>
    public class ChannelsECMerchantGetFreightTemplateDetailRequest : WechatApiRequest, IInferable<ChannelsECMerchantGetFreightTemplateDetailRequest, ChannelsECMerchantGetFreightTemplateDetailResponse>
    {
        /// <summary>
        /// 获取或设置运费模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public long TemplateId { get; set; }
    }
}
