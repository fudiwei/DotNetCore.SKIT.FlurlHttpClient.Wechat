namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/createpressuretesttask 接口的响应。</para>
    /// </summary>
    public class TCBCreatePressureTestTaskResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置压测 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pressure_id")]
        [System.Text.Json.Serialization.JsonPropertyName("pressure_id")]
        public int PressureId { get; set; }
    }
}
