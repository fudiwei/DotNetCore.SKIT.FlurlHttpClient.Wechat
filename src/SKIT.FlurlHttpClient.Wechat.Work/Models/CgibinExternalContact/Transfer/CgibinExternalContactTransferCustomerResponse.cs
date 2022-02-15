namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/transfer_customer 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactTransferCustomerResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Result
            {
                /// <summary>
                /// 获取或设置错误码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errcode")]
                [System.Text.Json.Serialization.JsonPropertyName("errcode")]
                public int ErrorCode { get; set; }

                /// <summary>
                /// 获取或设置外部联系人账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("external_userid")]
                public string ExternalUserId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("customer")]
        [System.Text.Json.Serialization.JsonPropertyName("customer")]
        public Types.Result[] ResultList { get; set; } = default!;
    }
}
