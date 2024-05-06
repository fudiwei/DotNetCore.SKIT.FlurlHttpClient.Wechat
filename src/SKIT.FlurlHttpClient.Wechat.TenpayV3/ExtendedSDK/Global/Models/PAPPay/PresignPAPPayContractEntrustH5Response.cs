namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global.Models
{
    /// <summary>
    /// <para>表示 [POST] /papay/contracts/h5-pre-entrust-sign 接口的响应。</para>
    /// </summary>
    public class PresignPAPPayContractEntrustH5Response : WechatTenpayGlobalResponse
    {
        /// <summary>
        /// 获取或设置委托代扣签约 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign_url")]
        [System.Text.Json.Serialization.JsonPropertyName("sign_url")]
        public string SignUrl { get; set; } = default!;
    }
}
