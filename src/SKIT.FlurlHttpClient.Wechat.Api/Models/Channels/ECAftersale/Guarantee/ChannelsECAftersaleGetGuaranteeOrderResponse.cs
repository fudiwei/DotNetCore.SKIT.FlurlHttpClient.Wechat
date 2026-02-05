namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/aftersale/getguaranteeorder 接口的响应。</para>
    /// </summary>
    public class ChannelsECAftersaleGetGuaranteeOrderResponse : WechatApiResponse
    {
        public static class Types
        {
            public class GuaranteeOrder : ChannelsECAftersaleSearchGuaranteeOrderResponse.Types.GuaranteeOrder
            {
            }
        }

        /// <summary>
        /// 获取或设置保障单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guarantee_order")]
        [System.Text.Json.Serialization.JsonPropertyName("guarantee_order")]
        public Types.GuaranteeOrder GuaranteeOrder { get; set; } = default!;
    }
}
