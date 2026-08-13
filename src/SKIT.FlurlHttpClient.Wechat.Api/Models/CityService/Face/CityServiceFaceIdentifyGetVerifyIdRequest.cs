namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cityservice/face/identify/getverifyid 接口的请求。</para>
    /// </summary>
    public class CityServiceFaceIdentifyGetVerifyIdRequest : WechatApiRequest, IInferable<CityServiceFaceIdentifyGetVerifyIdRequest, CityServiceFaceIdentifyGetVerifyIdResponse>
    {
        public static class Types
        {
            public class CertInfo
            {
                /// <summary>
                /// 获取或设置证件类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cert_type")]
                [System.Text.Json.Serialization.JsonPropertyName("cert_type")]
                public string CertType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置证件姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cert_name")]
                [System.Text.Json.Serialization.JsonPropertyName("cert_name")]
                public string CertName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置证件号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cert_no")]
                [System.Text.Json.Serialization.JsonPropertyName("cert_no")]
                public string CertNumber { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置业务方系统内部流水号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_seq_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_seq_no")]
        public string OutSequenceNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户身份信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cert_info")]
        [System.Text.Json.Serialization.JsonPropertyName("cert_info")]
        public Types.CertInfo CertInfo { get; set; } = new Types.CertInfo();
    }
}
