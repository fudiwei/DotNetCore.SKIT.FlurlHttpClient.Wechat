namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /vehicle/etc/preopen 接口的响应。</para>
    /// </summary>
    public class PreopenVehicleETCResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置预开通 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("preopen_id")]
        [System.Text.Json.Serialization.JsonPropertyName("preopen_id")]
        public string PreopenId { get; set; } = default!;
    }
}
