namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/getopendata 接口的请求。</para>
    /// </summary>
    public class TCBGetOpenDataRequest : WechatApiRequest, IInferable<TCBGetOpenDataRequest, TCBGetOpenDataResponse>
    {
        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置 CloudId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cloudid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("cloudid_list")]
        public List<string>? CloudIdList { get; set; }
    }
}
