namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/resigned/transfer_customer 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactResignedTransferCustomerResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Result : CgibinExternalContactTransferCustomerResponse.Types.Result
            {
            }
        }

        /// <summary>
        /// 获取或设置结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("customer")]
        [System.Text.Json.Serialization.JsonPropertyName("customer")]
        public List<Types.Result>? ResultList { get; set; }
    }
}
