namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/local/business/order/precancel 接口的响应。</para>
    /// </summary>
    public class CgibinExpressLocalBusinessOrderPreCancelResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置运力返回的错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resultcode")]
        [System.Text.Json.Serialization.JsonPropertyName("resultcode")]
        public int ResultCode { get; set; }

        /// <summary>
        /// 获取或设置运力返回的错误描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resultmsg")]
        [System.Text.Json.Serialization.JsonPropertyName("resultmsg")]
        public string ResultMessage { get; set; } = default!;

        /// <summary>
        /// 获取或设置扣除的违约金（单位：元）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deduct_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("deduct_fee")]
        public double DeductFee { get; set; }

        /// <summary>
        /// 获取或设置说明。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc")]
        [System.Text.Json.Serialization.JsonPropertyName("desc")]
        public string Description { get; set; } = default!;

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && ResultCode == 0;
        }
    }
}
