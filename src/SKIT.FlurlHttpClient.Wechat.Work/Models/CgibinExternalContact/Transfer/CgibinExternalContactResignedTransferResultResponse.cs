namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/resigned/transfer_result 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactResignedTransferResultResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Result : CgibinExternalContactTransferResultResponse.Types.Result
            {
            }
        }

        /// <summary>
        /// 获取或设置客户转交结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("customer")]
        [System.Text.Json.Serialization.JsonPropertyName("customer")]
        public List<Types.Result>? ResultList { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
