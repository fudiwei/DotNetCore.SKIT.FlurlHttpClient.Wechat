namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/getappealrecords 接口的请求。</para>
    /// </summary>
    public class WxaGetAppealRecordsRequest : WechatApiRequest, IInferable<WxaGetAppealRecordsRequest, WxaGetAppealRecordsResponse>
    {
        /// <summary>
        /// 获取或设置违规处罚记录 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("illegal_record_id")]
        [System.Text.Json.Serialization.JsonPropertyName("illegal_record_id")]
        public string IllegalRecordId { get; set; } = string.Empty;
    }
}
