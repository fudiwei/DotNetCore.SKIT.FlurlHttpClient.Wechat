namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/license/batch_transfer_license 接口的响应。</para>
    /// </summary>
    public class CgibinLicenseBatchTransferLicenseResponse : WechatWorkResponse
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
                /// 获取或设置转移成员的 UserId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("handover_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("handover_userid")]
                public string HandoverUserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置接收成员的 UserId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("takeover_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("takeover_userid")]
                public string TakeoverUserId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_result")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_result")]
        public Types.Result[] ResultList { get; set; } = default!;
    }
}
