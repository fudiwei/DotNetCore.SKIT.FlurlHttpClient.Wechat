namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /new-tax-control-fapiao/fapiao-applications/{fapiao_apply_id}/fapiao-files 接口的请求。</para>
    /// </summary>
    public class GetNewTaxControlFapiaoApplicationFilesRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置发票申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string FapiaoApplyId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户发票单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? FapiaoId { get; set; }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? SubMerchantId { get; set; }
    }
}
