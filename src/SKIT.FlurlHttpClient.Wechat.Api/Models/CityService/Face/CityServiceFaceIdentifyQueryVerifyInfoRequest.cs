using System;
using System.Text;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cityservice/face/identify/queryverifyinfo 接口的请求。</para>
    /// </summary>
    public class CityServiceFaceIdentifyQueryVerifyInfoRequest : WechatApiRequest, IInferable<CityServiceFaceIdentifyQueryVerifyInfoRequest, CityServiceFaceIdentifyQueryVerifyInfoResponse>
    {
        /// <summary>
        /// 获取或设置业务方系统内部流水号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_seq_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_seq_no")]
        public string OutSequenceNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置人脸核身会话唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("verify_id")]
        [System.Text.Json.Serialization.JsonPropertyName("verify_id")]
        public string VerifyId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置证件信息摘要。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cert_hash")]
        [System.Text.Json.Serialization.JsonPropertyName("cert_hash")]
        public string CertHash { get; set; } = string.Empty;

        public void SetCertHash(string certType, string certName, string certNumber)
        {
            if (certType is null) throw new ArgumentNullException(nameof(certType));
            if (certName is null) throw new ArgumentNullException(nameof(certName));
            if (certNumber is null) throw new ArgumentNullException(nameof(certNumber));

            string encodedCertType = Convert.ToBase64String(Encoding.UTF8.GetBytes(certType));
            string encodedCertName = Convert.ToBase64String(Encoding.UTF8.GetBytes(certName));
            string encodedCertNumber = Convert.ToBase64String(Encoding.UTF8.GetBytes(certNumber));
            string certInfoStr = $"cert_type={encodedCertType}&cert_name={encodedCertName}&cert_no={encodedCertNumber}";
            string certInfoHash = Utilities.SHA256Utility.Hash(certInfoStr).Value!.ToLower();
            CertHash = certInfoHash;
        }
    }
}
