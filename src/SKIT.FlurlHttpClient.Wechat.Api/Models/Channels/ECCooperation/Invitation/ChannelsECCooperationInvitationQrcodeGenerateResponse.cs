namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/cooperation/invitation/qrcode/generate 接口的响应。</para>
    /// </summary>
    public class ChannelsECCooperationInvitationQrcodeGenerateResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置经过 Base64 编码后的二维码数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qrcode_base64")]
                [System.Text.Json.Serialization.JsonPropertyName("qrcode_base64")]
                public string EncodingQrcodeData { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
