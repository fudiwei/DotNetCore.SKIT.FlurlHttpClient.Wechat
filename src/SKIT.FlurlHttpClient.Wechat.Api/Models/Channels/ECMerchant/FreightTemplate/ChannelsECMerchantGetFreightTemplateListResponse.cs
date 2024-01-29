namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/merchant/getfreighttemplatelist 接口的响应。</para>
    /// </summary>
    public class ChannelsECMerchantGetFreightTemplateListResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置运费模板 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id_list")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long[] TemplateIdList { get; set; } = default!;
    }
}
