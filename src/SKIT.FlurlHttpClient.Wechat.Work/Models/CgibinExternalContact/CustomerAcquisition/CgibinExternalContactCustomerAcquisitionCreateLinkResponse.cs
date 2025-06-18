namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/customer_acquisition/create_link 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactCustomerAcquisitionCreateLinkResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Link : CgibinExternalContactCustomerAcquisitionGetResponse.Types.Link
            {
            }
        }

        /// <summary>
        /// 获取或设置获客链接信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("link")]
        [System.Text.Json.Serialization.JsonPropertyName("link")]
        public Types.Link Link { get; set; } = default!;
    }
}
