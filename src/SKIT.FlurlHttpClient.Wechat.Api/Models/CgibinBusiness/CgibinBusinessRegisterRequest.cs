namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/business/register 接口的请求。</para>
    /// </summary>
    public class CgibinBusinessRegisterRequest : WechatApiRequest, IInferable<CgibinBusinessRegisterRequest, CgibinBusinessRegisterResponse>
    {
        /// <summary>
        /// 获取或设置商户账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_name")]
        [System.Text.Json.Serialization.JsonPropertyName("account_name")]
        public string AccountName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户昵称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nickname")]
        [System.Text.Json.Serialization.JsonPropertyName("nickname")]
        public string Nickname { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户头像 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("icon_media_id")]
        [System.Text.Json.Serialization.JsonPropertyName("icon_media_id")]
        public string IconMediaId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否将消息转发到通用客服。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_to_commkf")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_to_commkf")]
        public bool? IsTransferToCommonKf { get; set; }
    }
}
