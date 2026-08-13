namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /brand/card/card-configs/preview-url 接口的请求。</para>
    /// </summary>
    public class GetBrandCardConfigPreviewUrlRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置业务申请编号。与字段 <see cref="ApplymentId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? BusinessCode { get; set; }

        /// <summary>
        /// 获取或设置微信支付申请单号。与字段 <see cref="BusinessCode"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ApplymentId { get; set; }

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string BrandId { get; set; } = string.Empty;
    }
}
