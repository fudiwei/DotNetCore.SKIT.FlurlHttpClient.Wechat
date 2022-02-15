namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/local/business/delivery/getall 接口的响应。</para>
    /// </summary>
    public class CgibinExpressLocalBusinessDeliveryGetAllResponse : WechatApiResponse
    {
        public static class Types
        {
            public class DeliveryCompany
            {
                /// <summary>
                /// 获取或设置配送公司 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_id")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
                public string DeliveryId { get; set; } = default!;

                /// <summary>
                /// 获取或设置配送公司名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_name")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_name")]
                public string DeliveryName { get; set; } = default!;
            }
        }

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
        /// 获取或设置配送公司列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.DeliveryCompany[] DeliveryCompanyList { get; set; } = default!;

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && ResultCode == 0;
        }
    }
}
