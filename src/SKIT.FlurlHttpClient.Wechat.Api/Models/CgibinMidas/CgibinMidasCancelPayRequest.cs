namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/midas/cancelpay 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2022-11-05 下线。")]
    public class CgibinMidasCancelPayRequest : CgibinMidasRequestBase, IInferable<CgibinMidasCancelPayRequest, CgibinMidasCancelPayResponse>
    {
        /// <summary>
        /// 获取或设置订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_no")]
        [System.Text.Json.Serialization.JsonPropertyName("bill_no")]
        public string? BillNumber { get; set; }

        /// <summary>
        /// 获取或设置道具名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_item")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_item")]
        public string? PayItem { get; set; }

        protected internal override string GetRequestMethod()
        {
            return "POST";
        }

        protected internal override string GetRequestPath()
        {
            return "/cgi-bin/midas/cancelpay";
        }
    }
}
