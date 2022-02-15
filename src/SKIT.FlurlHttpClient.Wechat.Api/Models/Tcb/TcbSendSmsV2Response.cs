namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/sendsmsv2 接口的响应。</para>
    /// </summary>
    public class TcbSendSmsV2Response : WechatApiResponse
    {
        public static class Types
        {
            public class SendStatus : TcbSendSmsResponse.Types.SendStatus
            {
            }
        }

        /// <summary>
        /// 获取或设置发送状态列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("send_status_list")]
        [System.Text.Json.Serialization.JsonPropertyName("send_status_list")]
        public Types.SendStatus[]? SendStatusList { get; set; }
    }
}
